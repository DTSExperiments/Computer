library IEEE;
use IEEE.STD_LOGIC_1164.ALL;
use IEEE.numeric_std.all;

entity vga_800 is port(
	clk_vga: in std_logic;
	horizontal_counter : out integer range 0 to 2047;
	vertical_counter : out integer range 0 to 2047;
    hs_out   : out std_logic;
    vs_out   : out std_logic;
    frame_out: out std_logic;
    v_visible: out std_logic;
    h_visible: out std_logic;
    vid_screen_h: out integer range 0 to 2047;
    vid_screen_v: out integer range 0 to 2047;
    pVde: out std_logic
    );
end vga_800;

architecture Behavioral of vga_800 is

signal hc: integer range 0 to 1056:=0; -- whole-line
signal vc: integer range 0 to 628:=0; -- whole-frame

--signal vid_screen_v: integer range 0 to 2047:= 0;
--signal vid_screen_h: integer range 0 to 2047:= 0;

--signal hc: integer range 0 to 1040:=0; -- whole-line
--signal vc: integer range 0 to 666:=0; -- whole-frame

begin

horizontal_counter <= hc;
vertical_counter <= vc;

--horizontal_counter <= std_logic_vector(to_unsigned(hc,11));
--vertical_counter <= std_logic_vector(to_unsigned(vc,11));

--screen_v <= std_logic_vector(to_unsigned(vid_screen_v, 11));
--screen_h <= std_logic_vector(to_unsigned(vid_screen_h, 11));

process
begin
	wait until rising_edge(clk_vga);
--	if hc >= 856 and hc < 976 then
	if hc >= 0 and hc < 128 then -- 96 = Sync-pulsethen
		hs_out <= '1';
    else
		hs_out <= '0';
    end if;
    
    if vc >= 0 and vc < 4 then
--    if vc >= 490 and vc < 492 then -- 2 = Sync-pulse
		vs_out <= '1';
    else
		vs_out <= '0';
    end if;
    
	hc <= hc + 1;
		
	if (hc = 1055) then
--    if (hc = 799) then --799 = Whole-line
		vc <= vc + 1;
		hc <= 0;
    end if;
    
    if (vc = 627) and (hc = 1016) then
--    if (vc = 524) then --524 = Whole-frame    
		vc <= 0;
		frame_out <= '1';
	else
	   frame_out <= '0';
    end if;
    
    if (hc >= 216) and (hc < 1016) and (vc >= 27) and (vc < 627) then
        pVde <= '1';
    else
        pVde <= '0';
    end if;
    
    if (hc >= 216) and (hc < 1016) then
        h_visible <= '1';
        vid_screen_h <= hc - 216;
    else
        h_visible <= '0';
        vid_screen_h <= 2047;
    end if;
    
    if (vc >= 27) and (vc < 627) then
        v_visible <= '1';
        vid_screen_v <= vc - 27;
    else
        v_visible <= '0';
        vid_screen_v <= 2047;
    end if;
    
end process;

end Behavioral;
