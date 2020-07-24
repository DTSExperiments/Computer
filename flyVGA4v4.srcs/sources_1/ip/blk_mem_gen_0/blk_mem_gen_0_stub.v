// Copyright 1986-2020 Xilinx, Inc. All Rights Reserved.
// --------------------------------------------------------------------------------
// Tool Version: Vivado v.2020.1 (win64) Build 2902540 Wed May 27 19:54:49 MDT 2020
// Date        : Thu Jul 23 08:23:47 2020
// Host        : PC1012002888 running 64-bit major release  (build 9200)
// Command     : write_verilog -force -mode synth_stub
//               d:/workUni/brembs/flyVGA4v4/flyVGA4v4.srcs/sources_1/ip/blk_mem_gen_0/blk_mem_gen_0_stub.v
// Design      : blk_mem_gen_0
// Purpose     : Stub declaration of top-level module interface
// Device      : xc7a100tcsg324-1
// --------------------------------------------------------------------------------

// This empty module with port declaration file causes synthesis tools to infer a black box for IP.
// The synthesis directives are for Synopsys Synplify support to prevent IO buffer insertion.
// Please paste the declaration into a Verilog source file or add the file as an additional source.
(* x_core_info = "blk_mem_gen_v8_4_4,Vivado 2020.1" *)
module blk_mem_gen_0(clka, ena, wea, addra, dina, clkb, enb, addrb, doutb)
/* synthesis syn_black_box black_box_pad_pin="clka,ena,wea[0:0],addra[11:0],dina[799:0],clkb,enb,addrb[11:0],doutb[799:0]" */;
  input clka;
  input ena;
  input [0:0]wea;
  input [11:0]addra;
  input [799:0]dina;
  input clkb;
  input enb;
  input [11:0]addrb;
  output [799:0]doutb;
endmodule
