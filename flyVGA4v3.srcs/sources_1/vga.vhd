library IEEE;
use IEEE.STD_LOGIC_1164.ALL;
use IEEE.numeric_std.all;

entity vga_640 is port(
	clk_vga: in std_logic;
	horizontal_counter : out integer range 0 to 2047;
	vertical_counter   : out integer range 0 to 2047;
    hs_out   : out std_logic;
    vs_out   : out std_logic;
    v_visible: out std_logic;
    h_visible: out std_logic;
    vid_screen_h: out integer range 0 to 2047;
    vid_screen_v: out integer range 0 to 2047;
    pVde: out std_logic;
    frame_out: out std_logic
    );
end vga_640;

architecture Behavioral of vga_640 is

signal hc: integer range 0 to 1040:=0; -- whole-line
signal vc: integer range 0 to 666:=0; -- whole-frame

begin
horizontal_counter <= hc;
vertical_counter <= vc;
--Bild begint bei Sync-pulse
process
begin
	wait until rising_edge(clk_vga);
	
	if hc > 0 and hc < 120 then -- 96 = Sync-pulsethen
		hs_out <= '1';
    else
		hs_out <= '0';
    end if;
    
    if vc > 0 and vc < 6 then -- 2 = Sync-pulse
		vs_out <= '1';
    else
		vs_out <= '0';
    end if;
    
	hc <= hc + 1;
		
    if (hc = 1039) then --799 = Whole-line
		vc <= vc + 1;
		hc <= 0;
    end if;
    
    if (vc = 665) and (hc = 984) then --524 = Whole-frame    
		vc <= 0;
		frame_out <= '1';
	else
	   frame_out <= '0';
    end if;
    
    if (hc >= 184) and (hc < 984) and (vc >= 29) and (vc < 629) then
        pVde <= '1';
    else
        pVde <= '0';
    end if;
    
    if (hc >= 184) and (hc < 984) then
        h_visible <= '1';
        vid_screen_h <= hc - 184;
    else
        h_visible <= '0';
        vid_screen_h <= 2047;
    end if;
    
    if (vc >= 29) and (vc < 629) then
        v_visible <= '1';
        vid_screen_v <= vc - 29;
    else
        v_visible <= '0';
        vid_screen_v <= 2047;
    end if;
    
end process;

end Behavioral;

