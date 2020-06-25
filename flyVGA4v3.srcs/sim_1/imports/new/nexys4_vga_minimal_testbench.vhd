library ieee;
use ieee.std_logic_1164.all;
use ieee.numeric_std.all;

entity nexys4_vga_minimal_bench is
end nexys4_vga_minimal_bench;

architecture Behavioral of nexys4_vga_minimal_bench is

component nexys4_vga_minimal is Port(
    RsRx: in std_logic;
    RsTx: out std_logic;
	xadc_p: in std_logic;
    xadc_n: in std_logic;
    vauxp3: in std_logic;
    vauxn3: in std_logic;
	clk: in std_logic;
    vgaRed, vgaBlue, vgaGreen: out std_logic_vector(3 downto 0):=(others => '0');
    led: out std_logic_vector (15 downto 0):=(others => '0');
    sw: in std_logic_vector (15 downto 0);
    Hsync, Vsync: out std_logic);
end component;

signal clk_in: std_logic:='0';
signal sw_in: std_logic_vector (15 downto 0):= (others => '0');
signal uut_rsrx:std_logic:='1';
constant clk_in_half_period : time := 10 ns;

signal vga_r, vga_g, vga_b: std_logic_vector(3 downto 0):=(others => '0');
signal hs, vs: std_logic:='0';

signal RsTx_out, Hsync_out, Vsync_out: std_logic:='0';
signal led_out: std_logic_vector (15 downto 0):= (others => '0');

begin

uut: nexys4_vga_minimal port map(
    RsRx => uut_rsrx,
    xadc_p => '0',
    xadc_n => '0',
    vauxp3 => '0',
    vauxn3 => '0',
    sw => sw_in,
	clk => clk_in,
	RsTx => RsTx_out,
	led => led_out,
	vgaRed => vga_r,
	vgaBlue => vga_b,
	vgaGreen => vga_g,
	Hsync => Hsync_out,
	Vsync => Vsync_out);

clk_in <= not clk_in after clk_in_half_period;

uut_rsrx <= not uut_rsrx after  87 us;


--process begin
----    sw_in(2) <= '1';
----    wait for 5 ms;
----    sw_in(2) <= '0';
----    wait for 13 ms;
--end process;

end Behavioral;
