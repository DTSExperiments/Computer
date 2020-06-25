## This file is a general .xdc for the Nexys4 rev B board
## To use it in a project:
## - uncomment the lines corresponding to used pins
## - rename the used ports (in each line, after get_ports) according to the top level signal names in the project

## Clock signal
##Bank = 35, Pin name = IO_L12P_T1_MRCC_35,					Sch name = CLK100MHZ
set_property PACKAGE_PIN E3 [get_ports clk]							
	set_property IOSTANDARD LVCMOS33 [get_ports clk]
	create_clock -add -name sys_clk_pin -period 10.00 -waveform {0 5} [get_ports clk]

##VGA Connector
##Bank = 35, Pin name = IO_L8N_T1_AD14N_35,					Sch name = VGA_R0
set_property PACKAGE_PIN A3 [get_ports {vgaRed[0]}]				
	set_property IOSTANDARD LVCMOS33 [get_ports {vgaRed[0]}]
##Bank = 35, Pin name = IO_L7N_T1_AD6N_35,					Sch name = VGA_R1
set_property PACKAGE_PIN B4 [get_ports {vgaRed[1]}]				
	set_property IOSTANDARD LVCMOS33 [get_ports {vgaRed[1]}]
##Bank = 35, Pin name = IO_L1N_T0_AD4N_35,					Sch name = VGA_R2
set_property PACKAGE_PIN C5 [get_ports {vgaRed[2]}]				
	set_property IOSTANDARD LVCMOS33 [get_ports {vgaRed[2]}]
##Bank = 35, Pin name = IO_L8P_T1_AD14P_35,					Sch name = VGA_R3
set_property PACKAGE_PIN A4 [get_ports {vgaRed[3]}]				
	set_property IOSTANDARD LVCMOS33 [get_ports {vgaRed[3]}]
##Bank = 35, Pin name = IO_L2P_T0_AD12P_35,					Sch name = VGA_B0
set_property PACKAGE_PIN B7 [get_ports {vgaBlue[0]}]				
	set_property IOSTANDARD LVCMOS33 [get_ports {vgaBlue[0]}]
##Bank = 35, Pin name = IO_L4N_T0_35,						Sch name = VGA_B1
set_property PACKAGE_PIN C7 [get_ports {vgaBlue[1]}]				
	set_property IOSTANDARD LVCMOS33 [get_ports {vgaBlue[1]}]
##Bank = 35, Pin name = IO_L6N_T0_VREF_35,					Sch name = VGA_B2
set_property PACKAGE_PIN D7 [get_ports {vgaBlue[2]}]				
	set_property IOSTANDARD LVCMOS33 [get_ports {vgaBlue[2]}]
##Bank = 35, Pin name = IO_L4P_T0_35,						Sch name = VGA_B3
set_property PACKAGE_PIN D8 [get_ports {vgaBlue[3]}]				
	set_property IOSTANDARD LVCMOS33 [get_ports {vgaBlue[3]}]
##Bank = 35, Pin name = IO_L1P_T0_AD4P_35,					Sch name = VGA_G0
set_property PACKAGE_PIN C6 [get_ports {vgaGreen[0]}]				
	set_property IOSTANDARD LVCMOS33 [get_ports {vgaGreen[0]}]
##Bank = 35, Pin name = IO_L3N_T0_DQS_AD5N_35,				Sch name = VGA_G1
set_property PACKAGE_PIN A5 [get_ports {vgaGreen[1]}]				
	set_property IOSTANDARD LVCMOS33 [get_ports {vgaGreen[1]}]
##Bank = 35, Pin name = IO_L2N_T0_AD12N_35,					Sch name = VGA_G2
set_property PACKAGE_PIN B6 [get_ports {vgaGreen[2]}]				
	set_property IOSTANDARD LVCMOS33 [get_ports {vgaGreen[2]}]
##Bank = 35, Pin name = IO_L3P_T0_DQS_AD5P_35,				Sch name = VGA_G3
set_property PACKAGE_PIN A6 [get_ports {vgaGreen[3]}]				
	set_property IOSTANDARD LVCMOS33 [get_ports {vgaGreen[3]}]
##Bank = 15, Pin name = IO_L4P_T0_15,						Sch name = VGA_HS
set_property PACKAGE_PIN B11 [get_ports Hsync]						
	set_property IOSTANDARD LVCMOS33 [get_ports Hsync]
##Bank = 15, Pin name = IO_L3N_T0_DQS_AD1N_15,				Sch name = VGA_VS
set_property PACKAGE_PIN B12 [get_ports Vsync]						
	set_property IOSTANDARD LVCMOS33 [get_ports Vsync]
	
##Pmod Header JXADC
    ##Bank = 15, Pin name = IO_L9P_T1_DQS_AD3P_15,                Sch name = XADC1_P -> XA1_P
    set_property PACKAGE_PIN A13 [get_ports {vauxp3}]                
        set_property IOSTANDARD LVCMOS33 [get_ports {vauxp3}]
    ##Bank = 15, Pin name = IO_L8P_T1_AD10P_15,                    Sch name = XADC2_P -> XA2_P
    #set_property PACKAGE_PIN A15 [get_ports {vauxp10}]                
        #set_property IOSTANDARD LVCMOS33 [get_ports {vauxp10}]
    ##Bank = 15, Pin name = IO_L7P_T1_AD2P_15,                    Sch name = XADC3_P -> XA3_P
    #set_property PACKAGE_PIN B16 [get_ports {vauxp2}]                
        #set_property IOSTANDARD LVCMOS33 [get_ports {vauxp2}]
    ##Bank = 15, Pin name = IO_L10P_T1_AD11P_15,                    Sch name = XADC4_P -> XA4_P
    #set_property PACKAGE_PIN B18 [get_ports {vauxp11}]                
        #set_property IOSTANDARD LVCMOS33 [get_ports {vauxp11}]
    ##Bank = 15, Pin name = IO_L9N_T1_DQS_AD3N_15,                Sch name = XADC1_N -> XA1_N
    set_property PACKAGE_PIN A14 [get_ports {vauxn3}]                
        set_property IOSTANDARD LVCMOS33 [get_ports {vauxn3}]
    ##Bank = 15, Pin name = IO_L8N_T1_AD10N_15,                    Sch name = XADC2_N -> XA2_N
    #set_property PACKAGE_PIN A16 [get_ports {vauxn10}]                
        #set_property IOSTANDARD LVCMOS33 [get_ports {vauxn10}]
    ##Bank = 15, Pin name = IO_L7N_T1_AD2N_15,                    Sch name = XADC3_N -> XA3_N 
    #set_property PACKAGE_PIN B17 [get_ports {vauxn2}]                
        #set_property IOSTANDARD LVCMOS33 [get_ports {vauxn2}]
    ##Bank = 15, Pin name = IO_L10N_T1_AD11N_15,                    Sch name = XADC4_N -> XA4_N
    #set_property PACKAGE_PIN A18 [get_ports {vauxn11}]                
        #set_property IOSTANDARD LVCMOS33 [get_ports {vauxn11}]

## Switches
##Bank = 34, Pin name = IO_L21P_T3_DQS_34,					Sch name = SW0
set_property PACKAGE_PIN U9 [get_ports {sw[0]}]					
	set_property IOSTANDARD LVCMOS33 [get_ports {sw[0]}]
##Bank = 34, Pin name = IO_25_34,							Sch name = SW1
set_property PACKAGE_PIN U8 [get_ports {sw[1]}]					
	set_property IOSTANDARD LVCMOS33 [get_ports {sw[1]}]
##Bank = 34, Pin name = IO_L23P_T3_34,						Sch name = SW2
set_property PACKAGE_PIN R7 [get_ports {sw[2]}]					
	set_property IOSTANDARD LVCMOS33 [get_ports {sw[2]}]
##Bank = 34, Pin name = IO_L19P_T3_34,						Sch name = SW3
set_property PACKAGE_PIN R6 [get_ports {sw[3]}]					
	set_property IOSTANDARD LVCMOS33 [get_ports {sw[3]}]
##Bank = 34, Pin name = IO_L19N_T3_VREF_34,					Sch name = SW4
set_property PACKAGE_PIN R5 [get_ports {sw[4]}]					
	set_property IOSTANDARD LVCMOS33 [get_ports {sw[4]}]
##Bank = 34, Pin name = IO_L20P_T3_34,						Sch name = SW5
set_property PACKAGE_PIN V7 [get_ports {sw[5]}]					
	set_property IOSTANDARD LVCMOS33 [get_ports {sw[5]}]
##Bank = 34, Pin name = IO_L20N_T3_34,						Sch name = SW6
set_property PACKAGE_PIN V6 [get_ports {sw[6]}]					
	set_property IOSTANDARD LVCMOS33 [get_ports {sw[6]}]
##Bank = 34, Pin name = IO_L10P_T1_34,						Sch name = SW7
set_property PACKAGE_PIN V5 [get_ports {sw[7]}]					
	set_property IOSTANDARD LVCMOS33 [get_ports {sw[7]}]
##Bank = 34, Pin name = IO_L8P_T1-34,						Sch name = SW8
set_property PACKAGE_PIN U4 [get_ports {sw[8]}]					
	set_property IOSTANDARD LVCMOS33 [get_ports {sw[8]}]
##Bank = 34, Pin name = IO_L9N_T1_DQS_34,					Sch name = SW9
set_property PACKAGE_PIN V2 [get_ports {sw[9]}]					
	set_property IOSTANDARD LVCMOS33 [get_ports {sw[9]}]
##Bank = 34, Pin name = IO_L9P_T1_DQS_34,					Sch name = SW10
set_property PACKAGE_PIN U2 [get_ports {sw[10]}]					
	set_property IOSTANDARD LVCMOS33 [get_ports {sw[10]}]
##Bank = 34, Pin name = IO_L11N_T1_MRCC_34,					Sch name = SW11
set_property PACKAGE_PIN T3 [get_ports {sw[11]}]					
	set_property IOSTANDARD LVCMOS33 [get_ports {sw[11]}]
##Bank = 34, Pin name = IO_L17N_T2_34,						Sch name = SW12
set_property PACKAGE_PIN T1 [get_ports {sw[12]}]					
	set_property IOSTANDARD LVCMOS33 [get_ports {sw[12]}]
##Bank = 34, Pin name = IO_L11P_T1_SRCC_34,					Sch name = SW13
set_property PACKAGE_PIN R3 [get_ports {sw[13]}]					
	set_property IOSTANDARD LVCMOS33 [get_ports {sw[13]}]
##Bank = 34, Pin name = IO_L14N_T2_SRCC_34,					Sch name = SW14
set_property PACKAGE_PIN P3 [get_ports {sw[14]}]					
	set_property IOSTANDARD LVCMOS33 [get_ports {sw[14]}]
##Bank = 34, Pin name = IO_L14P_T2_SRCC_34,					Sch name = SW15
set_property PACKAGE_PIN P4 [get_ports {sw[15]}]					
	set_property IOSTANDARD LVCMOS33 [get_ports {sw[15]}]

 
 ## LEDs
        ##Bank = 34, Pin name = IO_L24N_T3_34,                        Sch name = LED0
        set_property PACKAGE_PIN T8 [get_ports {led[0]}]                    
            set_property IOSTANDARD LVCMOS33 [get_ports {led[0]}]
        ##Bank = 34, Pin name = IO_L21N_T3_DQS_34,                    Sch name = LED1
        set_property PACKAGE_PIN V9 [get_ports {led[1]}]                    
            set_property IOSTANDARD LVCMOS33 [get_ports {led[1]}]
        ##Bank = 34, Pin name = IO_L24P_T3_34,                        Sch name = LED2
        set_property PACKAGE_PIN R8 [get_ports {led[2]}]                    
            set_property IOSTANDARD LVCMOS33 [get_ports {led[2]}]
        ##Bank = 34, Pin name = IO_L23N_T3_34,                        Sch name = LED3
        set_property PACKAGE_PIN T6 [get_ports {led[3]}]                    
            set_property IOSTANDARD LVCMOS33 [get_ports {led[3]}]
        ##Bank = 34, Pin name = IO_L12P_T1_MRCC_34,                    Sch name = LED4
        set_property PACKAGE_PIN T5 [get_ports {led[4]}]                    
            set_property IOSTANDARD LVCMOS33 [get_ports {led[4]}]
        ##Bank = 34, Pin name = IO_L12N_T1_MRCC_34,                    Sch    name = LED5
        set_property PACKAGE_PIN T4 [get_ports {led[5]}]                    
            set_property IOSTANDARD LVCMOS33 [get_ports {led[5]}]
        ##Bank = 34, Pin name = IO_L22P_T3_34,                        Sch name = LED6
        set_property PACKAGE_PIN U7 [get_ports {led[6]}]                    
            set_property IOSTANDARD LVCMOS33 [get_ports {led[6]}]
        ##Bank = 34, Pin name = IO_L22N_T3_34,                        Sch name = LED7
        set_property PACKAGE_PIN U6 [get_ports {led[7]}]                    
            set_property IOSTANDARD LVCMOS33 [get_ports {led[7]}]
        ##Bank = 34, Pin name = IO_L10N_T1_34,                        Sch name = LED8
        set_property PACKAGE_PIN V4 [get_ports {led[8]}]                    
            set_property IOSTANDARD LVCMOS33 [get_ports {led[8]}]
        ##Bank = 34, Pin name = IO_L8N_T1_34,                        Sch name = LED9
        set_property PACKAGE_PIN U3 [get_ports {led[9]}]                    
            set_property IOSTANDARD LVCMOS33 [get_ports {led[9]}]
        ##Bank = 34, Pin name = IO_L7N_T1_34,                        Sch name = LED10
        set_property PACKAGE_PIN V1 [get_ports {led[10]}]                    
            set_property IOSTANDARD LVCMOS33 [get_ports {led[10]}]
        ##Bank = 34, Pin name = IO_L17P_T2_34,                        Sch name = LED11
        set_property PACKAGE_PIN R1 [get_ports {led[11]}]                    
            set_property IOSTANDARD LVCMOS33 [get_ports {led[11]}]
        ##Bank = 34, Pin name = IO_L13N_T2_MRCC_34,                    Sch name = LED12
        set_property PACKAGE_PIN P5 [get_ports {led[12]}]                    
            set_property IOSTANDARD LVCMOS33 [get_ports {led[12]}]
        ##Bank = 34, Pin name = IO_L7P_T1_34,                        Sch name = LED13
        set_property PACKAGE_PIN U1 [get_ports {led[13]}]                    
            set_property IOSTANDARD LVCMOS33 [get_ports {led[13]}]
        ##Bank = 34, Pin name = IO_L15N_T2_DQS_34,                    Sch name = LED14
        set_property PACKAGE_PIN R2 [get_ports {led[14]}]                    
            set_property IOSTANDARD LVCMOS33 [get_ports {led[14]}]
        ##Bank = 34, Pin name = IO_L15P_T2_DQS_34,                    Sch name = LED15
        set_property PACKAGE_PIN P2 [get_ports {led[15]}]                    
            set_property IOSTANDARD LVCMOS33 [get_ports {led[15]}]
 
   
 ##USB-RS232 Interface
        ##Bank = 35, Pin name = IO_L7P_T1_AD6P_35,                    Sch name = UART_TXD_IN
        set_property PACKAGE_PIN C4 [get_ports RsRx]                        
            set_property IOSTANDARD LVCMOS33 [get_ports RsRx]
        ##Bank = 35, Pin name = IO_L11N_T1_SRCC_35,                    Sch name = UART_RXD_OUT
        set_property PACKAGE_PIN D4 [get_ports RsTx]                        
            set_property IOSTANDARD LVCMOS33 [get_ports RsTx]