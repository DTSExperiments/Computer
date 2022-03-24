library IEEE;
use IEEE.STD_LOGIC_1164.ALL;
use ieee.numeric_std.all;

entity p13_UART is
	generic(
	clk_freq: integer;
	baudrate: integer);
	Port (
	clk : in std_logic;
	start_snd: in std_logic;
	start_rcv: out std_logic;
	byte_snd : in std_logic_vector(7 downto 0);
	byte_rcv : out std_logic_vector(7 downto 0);
	tx : out std_logic;
	rx : in std_logic;
	ready : out std_logic
	);
end p13_UART;

architecture Behavioral of p13_UART is

constant clockdivider_max: integer:=clk_freq/baudrate -1;
constant clockdivider_max_halbe: integer:=(clk_freq/baudrate -1)/2;
signal bitdauerzaehler_snd: integer range 0 to clockdivider_max:=clockdivider_max;
signal bitdauerzaehler_rcv: integer range 0 to clockdivider_max:=0;
signal bitzaehler_snd: integer range 0 to 9:=9;
signal bitzaehler_rcv: integer range 0 to 9:=0;
signal zustand_snd: integer range 0 to 1 :=0;
signal zustand_rcv: integer range 0 to 2 :=0;
signal reg_snd: std_logic_vector(9 downto 0):="1000000000";
signal reg_rcv: std_logic_vector(9 downto 0):="0000000000";
signal reg_rx: std_logic_vector(2 downto 0):="000";

begin

ready <= '0' when bitdauerzaehler_snd < clockdivider_max or bitzaehler_snd < 9 or start_snd = '1' else '1';
process begin
	wait until rising_edge(clk);
	
	if zustand_snd = 0 then --warten
		if start_snd = '1' then
			bitdauerzaehler_snd <= 0;
			bitzaehler_snd <= 0;
			zustand_snd <= 1;
			reg_snd(8 downto 1) <= byte_snd;
		end if;
		tx <= '1';
	elsif zustand_snd = 1 then --senden
		if bitdauerzaehler_snd < clockdivider_max then
			bitdauerzaehler_snd <= bitdauerzaehler_snd +1;
		else
			if bitzaehler_snd < 9 then
				bitdauerzaehler_snd <= 0;
			bitzaehler_snd <= bitzaehler_snd +1;
			end if;
		end if;
		if bitdauerzaehler_snd = clockdivider_max and bitzaehler_snd = 9 then
			zustand_snd <= 0;
		end if;
		tx <= reg_snd(bitzaehler_snd);
	end if;
	
end process;

process begin
	wait until rising_edge(clk);
	
	reg_rx <= rx & reg_rx(2 downto 1);
	
	if zustand_rcv = 0 then --warten
		start_rcv <= '0';
		if (not reg_rx(1) and reg_rx(0)) = '1' then
			bitdauerzaehler_rcv <= 0;
			bitzaehler_rcv <= 0;
			zustand_rcv <= 1;
			reg_rcv <= (others => '0');
		end if;
	elsif zustand_rcv = 1 then --empfangen_startbit
		if bitdauerzaehler_rcv < clockdivider_max_halbe then
			bitdauerzaehler_rcv <= bitdauerzaehler_rcv +1;
		else
			bitzaehler_rcv <= 1;
			zustand_rcv <= 2;
			bitdauerzaehler_rcv <= 0;
			reg_rcv(bitzaehler_rcv) <= reg_rx(0);
		end if;
	elsif zustand_rcv = 2 then --empfangen
		if bitdauerzaehler_rcv < clockdivider_max then
			bitdauerzaehler_rcv <= bitdauerzaehler_rcv +1;
		else
			bitdauerzaehler_rcv <= 0;
			bitzaehler_rcv <= bitzaehler_rcv +1;
			reg_rcv(bitzaehler_rcv) <= reg_rx(0);
		end if;
		if bitdauerzaehler_rcv = clockdivider_max and bitzaehler_rcv = 9 then
			if reg_rcv(0) = '0' and reg_rx(0) = '1' then
				start_rcv <= '1';
				byte_rcv <= reg_rcv(8 downto 1);
			end if;
			zustand_rcv <= 0;
		end if;
	end if;
	
end process;

end Behavioral;