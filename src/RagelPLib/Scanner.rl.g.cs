
#line 1 "Scanner.rl.cs"
 /*************************************************************************
	Author: Robert A. Olliff
	Date  : 1/16/2015 12:00:00 AM  

	This file probably has code in it and does stuff.
 ************************************************************************ */
//END STUPID COMMENT
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RagelP
{
    public partial class Scanner
    {
       
       // int _is_static = 0;
       
#line 21 "E:\\src\\public\\RagelP\\src\\RagelPLib\\Scanner.rl.g.cs"
static readonly sbyte[] _CppScanner_actions =  new sbyte [] {
	0, 1, 2, 1, 3, 1, 8, 1, 
	9, 1, 10, 1, 11, 1, 12, 1, 
	13, 1, 14, 1, 15, 1, 16, 1, 
	17, 1, 18, 1, 19, 1, 20, 1, 
	21, 1, 22, 1, 23, 1, 24, 1, 
	25, 1, 26, 1, 27, 1, 28, 1, 
	29, 1, 30, 1, 31, 1, 32, 1, 
	33, 1, 34, 1, 35, 1, 36, 1, 
	37, 1, 38, 1, 39, 1, 40, 1, 
	41, 1, 42, 1, 43, 1, 44, 1, 
	45, 1, 46, 1, 47, 1, 48, 1, 
	49, 1, 50, 1, 51, 1, 52, 1, 
	53, 1, 54, 1, 55, 1, 56, 2, 
	0, 1, 2, 3, 4, 2, 3, 5, 
	2, 3, 6, 2, 3, 7
};

static readonly short[] _CppScanner_key_offsets =  new short [] {
	0, 0, 2, 2, 3, 6, 6, 8, 
	12, 14, 19, 20, 21, 23, 26, 28, 
	31, 33, 37, 40, 43, 46, 49, 52, 
	55, 58, 61, 64, 67, 72, 76, 77, 
	78, 79, 80, 81, 82, 83, 84, 85, 
	86, 87, 88, 89, 92, 94, 98, 101, 
	104, 107, 110, 113, 116, 119, 122, 125, 
	128, 130, 133, 135, 141, 142, 144, 146, 
	147, 149, 151, 153, 155, 157, 159, 161, 
	163, 165, 166, 168, 170, 172, 174, 176, 
	178, 213, 216, 217, 218, 219, 221, 222, 
	224, 231, 239, 245, 254, 258, 262, 271, 
	272, 276, 279, 283, 293, 301, 310, 312, 
	321, 325, 335, 339, 348, 349, 350, 357, 
	366, 374, 382, 390, 398, 407, 416, 424, 
	432, 440, 448, 455, 463, 471, 479, 487, 
	495, 503, 512, 521, 530, 539, 548, 556, 
	565, 574, 583, 592, 600, 608, 615, 623, 
	631, 639, 647, 655, 663, 672, 681, 689, 
	698, 707, 716, 717
};

static readonly char[] _CppScanner_trans_keys =  new char [] {
	'\u0022', '\u005c', '\u000a', '\u000a', '\u0027', '\u005c', '\u0030', '\u0039', 
	'\u002b', '\u002d', '\u0030', '\u0039', '\u0030', '\u0039', '\u002e', '\u0045', 
	'\u0065', '\u0030', '\u0039', '\u002e', '\u002a', '\u002a', '\u002f', '\u000a', 
	'\u002f', '\u0041', '\u000a', '\u0041', '\u000a', '\u0041', '\u0044', '\u000a', 
	'\u0041', '\u000a', '\u0041', '\u0044', '\u0050', '\u000a', '\u0041', '\u0054', 
	'\u000a', '\u0041', '\u0045', '\u000a', '\u0041', '\u0052', '\u000a', '\u0041', 
	'\u005f', '\u000a', '\u0041', '\u0045', '\u000a', '\u0041', '\u0058', '\u000a', 
	'\u0041', '\u0050', '\u000a', '\u0041', '\u004f', '\u000a', '\u0041', '\u0052', 
	'\u000a', '\u0041', '\u0054', '\u000a', '\u0020', '\u0041', '\u0009', '\u000d', 
	'\u0020', '\u0041', '\u0009', '\u000d', '\u0044', '\u0041', '\u0050', '\u0054', 
	'\u0045', '\u0052', '\u005f', '\u0045', '\u0058', '\u0050', '\u004f', '\u0052', 
	'\u0054', '\u000a', '\u0041', '\u0044', '\u000a', '\u0041', '\u000a', '\u0041', 
	'\u0044', '\u0050', '\u000a', '\u0041', '\u0054', '\u000a', '\u0041', '\u0045', 
	'\u000a', '\u0041', '\u0052', '\u000a', '\u0041', '\u005f', '\u000a', '\u0041', 
	'\u0045', '\u000a', '\u0041', '\u0058', '\u000a', '\u0041', '\u0050', '\u000a', 
	'\u0041', '\u004f', '\u000a', '\u0041', '\u0052', '\u000a', '\u0041', '\u0054', 
	'\u0030', '\u0039', '\u002e', '\u0030', '\u0039', '\u0030', '\u0039', '\u0030', 
	'\u0039', '\u0041', '\u0046', '\u0061', '\u0066', '\u0045', '\u0045', '\u004e', 
	'\u0044', '\u0045', '\u0042', '\u0042', '\u004f', '\u0042', '\u0054', '\u0042', 
	'\u0054', '\u0042', '\u004f', '\u0042', '\u004d', '\u0042', '\u005f', '\u0042', 
	'\u0045', '\u0042', '\u004e', '\u0042', '\u0044', '\u0054', '\u004f', '\u0054', 
	'\u0050', '\u0054', '\u0054', '\u005f', '\u0045', '\u0054', '\u004e', '\u0054', 
	'\u0044', '\u0054', '\u000a', '\u0021', '\u0022', '\u0023', '\u0025', '\u0026', 
	'\u0027', '\u002a', '\u002b', '\u002d', '\u002e', '\u002f', '\u0030', '\u003a', 
	'\u003d', '\u0042', '\u004c', '\u0054', '\u005e', '\u005f', '\u007c', '\u0024', 
	'\u002c', '\u0031', '\u0039', '\u003b', '\u0040', '\u0041', '\u005a', '\u005b', 
	'\u0060', '\u0061', '\u007a', '\u007b', '\u007e', '\u000a', '\u0021', '\u007e', 
	'\u003d', '\u000a', '\u003d', '\u0026', '\u003d', '\u003d', '\u002b', '\u003d', 
	'\u002d', '\u002e', '\u0030', '\u003d', '\u003e', '\u0031', '\u0039', '\u0045', 
	'\u0046', '\u004c', '\u0065', '\u0066', '\u006c', '\u0030', '\u0039', '\u0046', 
	'\u004c', '\u0066', '\u006c', '\u0030', '\u0039', '\u002e', '\u0045', '\u004c', 
	'\u0055', '\u0065', '\u006c', '\u0075', '\u0030', '\u0039', '\u004c', '\u0055', 
	'\u006c', '\u0075', '\u004c', '\u0055', '\u006c', '\u0075', '\u002e', '\u0045', 
	'\u004c', '\u0055', '\u0065', '\u006c', '\u0075', '\u0030', '\u0039', '\u002a', 
	'\u002a', '\u002e', '\u0030', '\u0039', '\u002a', '\u002f', '\u003d', '\u0020', 
	'\u0041', '\u0009', '\u000d', '\u002e', '\u0045', '\u004c', '\u0055', '\u0065', 
	'\u006c', '\u0075', '\u0078', '\u0030', '\u0039', '\u0045', '\u0046', '\u004c', 
	'\u0065', '\u0066', '\u006c', '\u0030', '\u0039', '\u002e', '\u0045', '\u0046', 
	'\u004c', '\u0065', '\u0066', '\u006c', '\u0030', '\u0039', '\u0030', '\u0039', 
	'\u002e', '\u0045', '\u004c', '\u0055', '\u0065', '\u006c', '\u0075', '\u0030', 
	'\u0039', '\u004c', '\u0055', '\u006c', '\u0075', '\u004c', '\u0055', '\u006c', 
	'\u0075', '\u0030', '\u0039', '\u0041', '\u0046', '\u0061', '\u0066', '\u004c', 
	'\u0055', '\u006c', '\u0075', '\u002e', '\u0045', '\u004c', '\u0055', '\u0065', 
	'\u006c', '\u0075', '\u0030', '\u0039', '\u003a', '\u003d', '\u005f', '\u0030', 
	'\u0039', '\u0041', '\u005a', '\u0061', '\u007a', '\u0045', '\u004f', '\u005f', 
	'\u0030', '\u0039', '\u0041', '\u005a', '\u0061', '\u007a', '\u0047', '\u005f', 
	'\u0030', '\u0039', '\u0041', '\u005a', '\u0061', '\u007a', '\u0049', '\u005f', 
	'\u0030', '\u0039', '\u0041', '\u005a', '\u0061', '\u007a', '\u004e', '\u005f', 
	'\u0030', '\u0039', '\u0041', '\u005a', '\u0061', '\u007a', '\u0045', '\u005f', 
	'\u0030', '\u0039', '\u0041', '\u005a', '\u0061', '\u007a', '\u0045', '\u004e', 
	'\u005f', '\u0030', '\u0039', '\u0041', '\u005a', '\u0061', '\u007a', '\u0044', 
	'\u0045', '\u005f', '\u0030', '\u0039', '\u0041', '\u005a', '\u0061', '\u007a', 
	'\u0054', '\u005f', '\u0030', '\u0039', '\u0041', '\u005a', '\u0061', '\u007a', 
	'\u0054', '\u005f', '\u0030', '\u0039', '\u0041', '\u005a', '\u0061', '\u007a', 
	'\u004f', '\u005f', '\u0030', '\u0039', '\u0041', '\u005a', '\u0061', '\u007a', 
	'\u004d', '\u005f', '\u0030', '\u0039', '\u0041', '\u005a', '\u0061', '\u007a', 
	'\u005f', '\u0030', '\u0039', '\u0041', '\u005a', '\u0061', '\u007a', '\u0042', 
	'\u005f', '\u0030', '\u0039', '\u0041', '\u005a', '\u0061', '\u007a', '\u0045', 
	'\u005f', '\u0030', '\u0039', '\u0041', '\u005a', '\u0061', '\u007a', '\u0047', 
	'\u005f', '\u0030', '\u0039', '\u0041', '\u005a', '\u0061', '\u007a', '\u0049', 
	'\u005f', '\u0030', '\u0039', '\u0041', '\u005a', '\u0061', '\u007a', '\u004e', 
	'\u005f', '\u0030', '\u0039', '\u0041', '\u005a', '\u0061', '\u007a', '\u0042', 
	'\u005f', '\u0030', '\u0039', '\u0041', '\u005a', '\u0061', '\u007a', '\u0042', 
	'\u004f', '\u005f', '\u0030', '\u0039', '\u0041', '\u005a', '\u0061', '\u007a', 
	'\u0042', '\u0054', '\u005f', '\u0030', '\u0039', '\u0041', '\u005a', '\u0061', 
	'\u007a', '\u0042', '\u0054', '\u005f', '\u0030', '\u0039', '\u0041', '\u005a', 
	'\u0061', '\u007a', '\u0042', '\u004f', '\u005f', '\u0030', '\u0039', '\u0041', 
	'\u005a', '\u0061', '\u007a', '\u0042', '\u004d', '\u005f', '\u0030', '\u0039', 
	'\u0041', '\u005a', '\u0061', '\u007a', '\u0042', '\u005f', '\u0030', '\u0039', 
	'\u0041', '\u005a', '\u0061', '\u007a', '\u0042', '\u0045', '\u005f', '\u0030', 
	'\u0039', '\u0041', '\u005a', '\u0061', '\u007a', '\u0042', '\u004e', '\u005f', 
	'\u0030', '\u0039', '\u0041', '\u005a', '\u0061', '\u007a', '\u0042', '\u0044', 
	'\u005f', '\u0030', '\u0039', '\u0041', '\u005a', '\u0061', '\u007a', '\u0022', 
	'\u0027', '\u005f', '\u0030', '\u0039', '\u0041', '\u005a', '\u0061', '\u007a', 
	'\u004f', '\u005f', '\u0030', '\u0039', '\u0041', '\u005a', '\u0061', '\u007a', 
	'\u0050', '\u005f', '\u0030', '\u0039', '\u0041', '\u005a', '\u0061', '\u007a', 
	'\u005f', '\u0030', '\u0039', '\u0041', '\u005a', '\u0061', '\u007a', '\u0042', 
	'\u005f', '\u0030', '\u0039', '\u0041', '\u005a', '\u0061', '\u007a', '\u0045', 
	'\u005f', '\u0030', '\u0039', '\u0041', '\u005a', '\u0061', '\u007a', '\u0047', 
	'\u005f', '\u0030', '\u0039', '\u0041', '\u005a', '\u0061', '\u007a', '\u0049', 
	'\u005f', '\u0030', '\u0039', '\u0041', '\u005a', '\u0061', '\u007a', '\u004e', 
	'\u005f', '\u0030', '\u0039', '\u0041', '\u005a', '\u0061', '\u007a', '\u0054', 
	'\u005f', '\u0030', '\u0039', '\u0041', '\u005a', '\u0061', '\u007a', '\u004f', 
	'\u0054', '\u005f', '\u0030', '\u0039', '\u0041', '\u005a', '\u0061', '\u007a', 
	'\u0050', '\u0054', '\u005f', '\u0030', '\u0039', '\u0041', '\u005a', '\u0061', 
	'\u007a', '\u0054', '\u005f', '\u0030', '\u0039', '\u0041', '\u005a', '\u0061', 
	'\u007a', '\u0045', '\u0054', '\u005f', '\u0030', '\u0039', '\u0041', '\u005a', 
	'\u0061', '\u007a', '\u004e', '\u0054', '\u005f', '\u0030', '\u0039', '\u0041', 
	'\u005a', '\u0061', '\u007a', '\u0044', '\u0054', '\u005f', '\u0030', '\u0039', 
	'\u0041', '\u005a', '\u0061', '\u007a', '\u003d', '\u003d', '\u007c', (char) 0
};

static readonly sbyte[] _CppScanner_single_lengths =  new sbyte [] {
	0, 2, 0, 1, 3, 0, 0, 2, 
	0, 3, 1, 1, 2, 3, 2, 3, 
	2, 4, 3, 3, 3, 3, 3, 3, 
	3, 3, 3, 3, 3, 2, 1, 1, 
	1, 1, 1, 1, 1, 1, 1, 1, 
	1, 1, 1, 3, 2, 4, 3, 3, 
	3, 3, 3, 3, 3, 3, 3, 3, 
	0, 1, 0, 0, 1, 2, 2, 1, 
	2, 2, 2, 2, 2, 2, 2, 2, 
	2, 1, 2, 2, 2, 2, 2, 2, 
	21, 1, 1, 1, 1, 2, 1, 2, 
	5, 6, 4, 7, 4, 4, 7, 1, 
	2, 3, 2, 8, 6, 7, 0, 7, 
	4, 4, 4, 7, 1, 1, 1, 3, 
	2, 2, 2, 2, 3, 3, 2, 2, 
	2, 2, 1, 2, 2, 2, 2, 2, 
	2, 3, 3, 3, 3, 3, 2, 3, 
	3, 3, 3, 2, 2, 1, 2, 2, 
	2, 2, 2, 2, 3, 3, 2, 3, 
	3, 3, 1, 2
};

static readonly sbyte[] _CppScanner_range_lengths =  new sbyte [] {
	0, 0, 0, 0, 0, 0, 1, 1, 
	1, 1, 0, 0, 0, 0, 0, 0, 
	0, 0, 0, 0, 0, 0, 0, 0, 
	0, 0, 0, 0, 1, 1, 0, 0, 
	0, 0, 0, 0, 0, 0, 0, 0, 
	0, 0, 0, 0, 0, 0, 0, 0, 
	0, 0, 0, 0, 0, 0, 0, 0, 
	1, 1, 1, 3, 0, 0, 0, 0, 
	0, 0, 0, 0, 0, 0, 0, 0, 
	0, 0, 0, 0, 0, 0, 0, 0, 
	7, 1, 0, 0, 0, 0, 0, 0, 
	1, 1, 1, 1, 0, 0, 1, 0, 
	1, 0, 1, 1, 1, 1, 1, 1, 
	0, 3, 0, 1, 0, 0, 3, 3, 
	3, 3, 3, 3, 3, 3, 3, 3, 
	3, 3, 3, 3, 3, 3, 3, 3, 
	3, 3, 3, 3, 3, 3, 3, 3, 
	3, 3, 3, 3, 3, 3, 3, 3, 
	3, 3, 3, 3, 3, 3, 3, 3, 
	3, 3, 0, 0
};

static readonly short[] _CppScanner_index_offsets =  new short [] {
	0, 0, 3, 4, 6, 10, 11, 13, 
	17, 19, 24, 26, 28, 31, 35, 38, 
	42, 45, 50, 54, 58, 62, 66, 70, 
	74, 78, 82, 86, 90, 95, 99, 101, 
	103, 105, 107, 109, 111, 113, 115, 117, 
	119, 121, 123, 125, 129, 132, 137, 141, 
	145, 149, 153, 157, 161, 165, 169, 173, 
	177, 179, 182, 184, 188, 190, 193, 196, 
	198, 201, 204, 207, 210, 213, 216, 219, 
	222, 225, 227, 230, 233, 236, 239, 242, 
	245, 274, 277, 279, 281, 283, 286, 288, 
	291, 298, 306, 312, 321, 326, 331, 340, 
	342, 346, 350, 354, 364, 372, 381, 383, 
	392, 397, 405, 410, 419, 421, 423, 428, 
	435, 441, 447, 453, 459, 466, 473, 479, 
	485, 491, 497, 502, 508, 514, 520, 526, 
	532, 538, 545, 552, 559, 566, 573, 579, 
	586, 593, 600, 607, 613, 619, 624, 630, 
	636, 642, 648, 654, 660, 667, 674, 680, 
	687, 694, 701, 703
};

static readonly byte[] _CppScanner_indicies =  new byte [] {
	2, 3, 1, 1, 6, 5, 0, 8, 
	9, 7, 7, 10, 4, 11, 11, 12, 
	0, 12, 0, 10, 15, 15, 14, 13, 
	16, 4, 18, 17, 18, 19, 17, 21, 
	22, 23, 20, 21, 23, 20, 21, 23, 
	24, 20, 21, 25, 20, 21, 23, 24, 
	26, 20, 21, 23, 27, 20, 21, 23, 
	28, 20, 21, 23, 29, 20, 21, 23, 
	30, 20, 21, 23, 31, 20, 21, 23, 
	32, 20, 21, 23, 33, 20, 21, 23, 
	34, 20, 21, 23, 35, 20, 21, 23, 
	4, 20, 36, 22, 37, 22, 20, 39, 
	40, 39, 38, 41, 38, 42, 38, 43, 
	38, 44, 38, 45, 38, 46, 38, 47, 
	38, 48, 38, 49, 38, 50, 38, 51, 
	38, 52, 38, 53, 38, 21, 23, 54, 
	20, 21, 55, 20, 21, 23, 24, 56, 
	20, 21, 23, 57, 20, 21, 23, 58, 
	20, 21, 23, 59, 20, 21, 23, 60, 
	20, 21, 23, 61, 20, 21, 23, 62, 
	20, 21, 23, 63, 20, 21, 23, 64, 
	20, 21, 23, 65, 20, 21, 23, 53, 
	20, 67, 66, 68, 67, 66, 69, 66, 
	70, 70, 70, 13, 73, 72, 73, 74, 
	72, 75, 73, 72, 77, 76, 77, 78, 
	76, 77, 79, 76, 77, 80, 76, 77, 
	81, 76, 77, 82, 76, 77, 83, 76, 
	77, 84, 76, 77, 85, 76, 77, 86, 
	76, 88, 87, 89, 88, 87, 90, 88, 
	87, 88, 91, 87, 92, 88, 87, 93, 
	88, 87, 94, 88, 87, 96, 97, 1, 
	98, 100, 101, 7, 102, 103, 104, 105, 
	106, 107, 109, 110, 112, 113, 114, 115, 
	111, 116, 99, 108, 99, 111, 99, 111, 
	99, 95, 117, 117, 95, 119, 118, 6, 
	5, 120, 118, 121, 122, 118, 123, 118, 
	124, 125, 118, 126, 127, 128, 130, 131, 
	129, 118, 15, 133, 133, 15, 133, 133, 
	10, 132, 133, 133, 133, 133, 12, 132, 
	10, 15, 135, 135, 15, 135, 135, 14, 
	134, 136, 136, 136, 136, 134, 137, 137, 
	137, 137, 134, 10, 15, 135, 135, 15, 
	135, 135, 129, 134, 139, 138, 140, 141, 
	10, 118, 17, 142, 143, 118, 39, 40, 
	39, 144, 145, 15, 135, 135, 15, 135, 
	135, 147, 146, 134, 15, 133, 133, 15, 
	133, 133, 148, 132, 149, 15, 133, 133, 
	15, 133, 133, 148, 132, 69, 150, 145, 
	15, 152, 152, 15, 152, 152, 146, 151, 
	153, 153, 153, 153, 151, 155, 155, 155, 
	155, 70, 70, 70, 154, 156, 156, 156, 
	156, 154, 145, 15, 135, 135, 15, 135, 
	135, 108, 134, 157, 118, 158, 118, 111, 
	111, 111, 111, 159, 160, 161, 111, 111, 
	111, 111, 159, 162, 111, 111, 111, 111, 
	159, 163, 111, 111, 111, 111, 159, 164, 
	111, 111, 111, 111, 159, 165, 164, 164, 
	164, 164, 72, 165, 166, 164, 164, 164, 
	164, 72, 111, 165, 164, 164, 164, 164, 
	72, 167, 111, 111, 111, 111, 159, 168, 
	111, 111, 111, 111, 159, 169, 111, 111, 
	111, 111, 159, 170, 111, 111, 111, 111, 
	159, 171, 111, 111, 111, 159, 172, 111, 
	111, 111, 111, 159, 173, 111, 111, 111, 
	111, 159, 174, 111, 111, 111, 111, 159, 
	175, 111, 111, 111, 111, 159, 176, 111, 
	111, 111, 111, 159, 177, 176, 176, 176, 
	176, 76, 177, 178, 176, 176, 176, 176, 
	76, 177, 179, 176, 176, 176, 176, 76, 
	177, 180, 176, 176, 176, 176, 76, 177, 
	181, 176, 176, 176, 176, 76, 177, 182, 
	176, 176, 176, 176, 76, 177, 183, 176, 
	176, 176, 76, 177, 184, 176, 176, 176, 
	176, 76, 177, 185, 176, 176, 176, 176, 
	76, 177, 111, 176, 176, 176, 176, 76, 
	1, 7, 111, 111, 111, 111, 159, 186, 
	111, 111, 111, 111, 159, 187, 111, 111, 
	111, 111, 159, 188, 111, 111, 111, 159, 
	189, 111, 111, 111, 111, 159, 190, 111, 
	111, 111, 111, 159, 191, 111, 111, 111, 
	111, 159, 192, 111, 111, 111, 111, 159, 
	193, 111, 111, 111, 111, 159, 194, 193, 
	193, 193, 193, 87, 195, 194, 193, 193, 
	193, 193, 87, 196, 194, 193, 193, 193, 
	193, 87, 194, 197, 193, 193, 193, 87, 
	198, 194, 193, 193, 193, 193, 87, 199, 
	194, 193, 193, 193, 193, 87, 111, 194, 
	193, 193, 193, 193, 87, 200, 118, 201, 
	202, 118, 0
};

static readonly byte[] _CppScanner_trans_targs =  new byte [] {
	80, 1, 80, 2, 80, 3, 80, 4, 
	80, 5, 89, 8, 90, 80, 9, 7, 
	80, 11, 12, 80, 14, 80, 28, 15, 
	16, 17, 18, 19, 20, 21, 22, 23, 
	24, 25, 26, 27, 98, 43, 80, 29, 
	30, 31, 32, 33, 34, 35, 36, 37, 
	38, 39, 40, 41, 42, 80, 44, 45, 
	46, 47, 48, 49, 50, 51, 52, 53, 
	54, 55, 80, 57, 58, 102, 105, 80, 
	60, 61, 62, 80, 63, 64, 65, 66, 
	67, 68, 69, 70, 71, 72, 80, 73, 
	74, 75, 76, 77, 78, 79, 80, 81, 
	80, 82, 83, 80, 84, 85, 86, 87, 
	88, 96, 97, 99, 107, 108, 109, 110, 
	111, 138, 139, 154, 155, 80, 80, 80, 
	80, 80, 80, 80, 80, 80, 80, 6, 
	91, 94, 80, 95, 80, 80, 80, 92, 
	93, 80, 80, 80, 80, 10, 13, 80, 
	80, 100, 103, 59, 101, 56, 80, 80, 
	104, 80, 80, 106, 80, 80, 80, 80, 
	112, 118, 113, 114, 115, 116, 117, 119, 
	120, 121, 122, 123, 124, 125, 126, 127, 
	128, 129, 130, 131, 132, 133, 134, 135, 
	136, 137, 140, 141, 142, 143, 144, 145, 
	146, 147, 148, 149, 150, 151, 152, 153, 
	80, 80, 80
};

static readonly sbyte[] _CppScanner_trans_actions =  new sbyte [] {
	101, 0, 7, 0, 97, 0, 69, 0, 
	5, 0, 109, 0, 0, 95, 0, 0, 
	53, 0, 0, 65, 0, 67, 0, 0, 
	0, 0, 0, 0, 0, 0, 0, 0, 
	0, 0, 0, 0, 3, 0, 99, 0, 
	0, 0, 0, 0, 0, 0, 0, 0, 
	0, 0, 0, 0, 0, 57, 0, 0, 
	0, 0, 0, 0, 0, 0, 0, 0, 
	0, 0, 93, 0, 0, 0, 0, 91, 
	0, 0, 0, 59, 0, 0, 0, 0, 
	0, 0, 0, 0, 0, 0, 63, 0, 
	0, 0, 0, 0, 0, 0, 61, 0, 
	51, 0, 3, 55, 0, 0, 0, 0, 
	3, 3, 3, 112, 112, 0, 0, 0, 
	0, 106, 0, 0, 0, 89, 85, 21, 
	31, 23, 37, 27, 43, 33, 45, 0, 
	112, 112, 35, 0, 75, 9, 77, 0, 
	0, 11, 83, 47, 49, 0, 0, 29, 
	87, 109, 115, 0, 109, 0, 73, 79, 
	0, 13, 81, 0, 15, 17, 19, 71, 
	0, 0, 0, 0, 3, 3, 3, 0, 
	0, 0, 0, 0, 0, 0, 0, 0, 
	3, 3, 3, 3, 3, 3, 3, 3, 
	3, 3, 0, 0, 0, 0, 0, 0, 
	0, 3, 3, 3, 3, 3, 3, 3, 
	39, 41, 25
};

static readonly sbyte[] _CppScanner_to_state_actions =  new sbyte [] {
	0, 0, 0, 0, 0, 0, 0, 0, 
	0, 0, 0, 0, 0, 0, 0, 0, 
	0, 0, 0, 0, 0, 0, 0, 0, 
	0, 0, 0, 0, 0, 0, 0, 0, 
	0, 0, 0, 0, 0, 0, 0, 0, 
	0, 0, 0, 0, 0, 0, 0, 0, 
	0, 0, 0, 0, 0, 0, 0, 0, 
	0, 0, 0, 0, 0, 0, 0, 0, 
	0, 0, 0, 0, 0, 0, 0, 0, 
	0, 0, 0, 0, 0, 0, 0, 0, 
	103, 0, 0, 0, 0, 0, 0, 0, 
	0, 0, 0, 0, 0, 0, 0, 0, 
	0, 0, 0, 0, 0, 0, 0, 0, 
	0, 0, 0, 0, 0, 0, 0, 0, 
	0, 0, 0, 0, 0, 0, 0, 0, 
	0, 0, 0, 0, 0, 0, 0, 0, 
	0, 0, 0, 0, 0, 0, 0, 0, 
	0, 0, 0, 0, 0, 0, 0, 0, 
	0, 0, 0, 0, 0, 0, 0, 0, 
	0, 0, 0, 0
};

static readonly sbyte[] _CppScanner_from_state_actions =  new sbyte [] {
	0, 0, 0, 0, 0, 0, 0, 0, 
	0, 0, 0, 0, 0, 0, 0, 0, 
	0, 0, 0, 0, 0, 0, 0, 0, 
	0, 0, 0, 0, 0, 0, 0, 0, 
	0, 0, 0, 0, 0, 0, 0, 0, 
	0, 0, 0, 0, 0, 0, 0, 0, 
	0, 0, 0, 0, 0, 0, 0, 0, 
	0, 0, 0, 0, 0, 0, 0, 0, 
	0, 0, 0, 0, 0, 0, 0, 0, 
	0, 0, 0, 0, 0, 0, 0, 0, 
	1, 0, 0, 0, 0, 0, 0, 0, 
	0, 0, 0, 0, 0, 0, 0, 0, 
	0, 0, 0, 0, 0, 0, 0, 0, 
	0, 0, 0, 0, 0, 0, 0, 0, 
	0, 0, 0, 0, 0, 0, 0, 0, 
	0, 0, 0, 0, 0, 0, 0, 0, 
	0, 0, 0, 0, 0, 0, 0, 0, 
	0, 0, 0, 0, 0, 0, 0, 0, 
	0, 0, 0, 0, 0, 0, 0, 0, 
	0, 0, 0, 0
};

static readonly short[] _CppScanner_eof_trans =  new short [] {
	0, 1, 1, 5, 1, 1, 5, 1, 
	1, 14, 5, 5, 5, 5, 5, 5, 
	5, 5, 5, 5, 5, 5, 5, 5, 
	5, 5, 5, 5, 5, 39, 39, 39, 
	39, 39, 39, 39, 39, 39, 39, 39, 
	39, 39, 39, 5, 5, 5, 5, 5, 
	5, 5, 5, 5, 5, 5, 5, 5, 
	67, 67, 67, 14, 72, 72, 72, 72, 
	72, 72, 72, 72, 72, 72, 72, 72, 
	72, 72, 72, 72, 72, 72, 72, 72, 
	0, 118, 119, 119, 119, 119, 119, 119, 
	119, 133, 133, 135, 135, 135, 135, 139, 
	119, 119, 145, 135, 133, 133, 151, 152, 
	152, 155, 155, 135, 119, 119, 160, 160, 
	160, 160, 160, 160, 160, 160, 160, 160, 
	160, 160, 160, 160, 160, 160, 160, 160, 
	160, 160, 160, 160, 160, 160, 160, 160, 
	160, 160, 160, 160, 160, 160, 160, 160, 
	160, 160, 160, 160, 160, 160, 160, 160, 
	160, 160, 119, 119
};

const int CppScanner_start = 80;
const int CppScanner_error = 0;

const int CppScanner_en_main = 80;


#line 105 "Scanner.rl.cs"

      
        //TagData _td;
        LinkedList<TokenData> _list = new LinkedList<TokenData>();
        //LinkedListNode<TokenData> _target = null;

        int cs =0;
	    public void init()
	    {
            
#line 457 "E:\\src\\public\\RagelP\\src\\RagelPLib\\Scanner.rl.g.cs"
	{
	cs = CppScanner_start;
	ts = -1;
	te = -1;
	act = 0;
	}

#line 115 "Scanner.rl.cs"
            
	    }

	    public override void exec(char[] data, int len )
	    {
            //current_package = pkg;
            _data = data;
		    p = 0;
		    pe = len;
		    int eof = len;
            line = 1;
            col = 0;
		    //string _s;
		    
#line 476 "E:\\src\\public\\RagelP\\src\\RagelPLib\\Scanner.rl.g.cs"
	{
	sbyte _klen;
	short _trans;
	int _acts;
	int _nacts;
	short _keys;

	if ( p == pe )
		goto _test_eof;
	if ( cs == 0 )
		goto _out;
_resume:
	_acts = _CppScanner_from_state_actions[cs];
	_nacts = _CppScanner_actions[_acts++];
	while ( _nacts-- > 0 ) {
		switch ( _CppScanner_actions[_acts++] ) {
	case 2:
#line 1 "NONE"
	{ts = p;}
	break;
#line 495 "E:\\src\\public\\RagelP\\src\\RagelPLib\\Scanner.rl.g.cs"
		default: break;
		}
	}

	_keys = _CppScanner_key_offsets[cs];
	_trans = (short)_CppScanner_index_offsets[cs];

	_klen = _CppScanner_single_lengths[cs];
	if ( _klen > 0 ) {
		short _lower = _keys;
		short _mid;
		short _upper = (short) (_keys + _klen - 1);
		while (true) {
			if ( _upper < _lower )
				break;

			_mid = (short) (_lower + ((_upper-_lower) >> 1));
			if ( data[p] < _CppScanner_trans_keys[_mid] )
				_upper = (short) (_mid - 1);
			else if ( data[p] > _CppScanner_trans_keys[_mid] )
				_lower = (short) (_mid + 1);
			else {
				_trans += (short) (_mid - _keys);
				goto _match;
			}
		}
		_keys += (short) _klen;
		_trans += (short) _klen;
	}

	_klen = _CppScanner_range_lengths[cs];
	if ( _klen > 0 ) {
		short _lower = _keys;
		short _mid;
		short _upper = (short) (_keys + (_klen<<1) - 2);
		while (true) {
			if ( _upper < _lower )
				break;

			_mid = (short) (_lower + (((_upper-_lower) >> 1) & ~1));
			if ( data[p] < _CppScanner_trans_keys[_mid] )
				_upper = (short) (_mid - 2);
			else if ( data[p] > _CppScanner_trans_keys[_mid+1] )
				_lower = (short) (_mid + 2);
			else {
				_trans += (short)((_mid - _keys)>>1);
				goto _match;
			}
		}
		_trans += (short) _klen;
	}

_match:
	_trans = (short)_CppScanner_indicies[_trans];
_eof_trans:
	cs = _CppScanner_trans_targs[_trans];

	if ( _CppScanner_trans_actions[_trans] == 0 )
		goto _again;

	_acts = _CppScanner_trans_actions[_trans];
	_nacts = _CppScanner_actions[_acts++];
	while ( _nacts-- > 0 )
	{
		switch ( _CppScanner_actions[_acts++] )
		{
	case 3:
#line 1 "NONE"
	{te = p+1;}
	break;
	case 4:
#line 44 "Scanner.rl.cs"
	{act = 3;}
	break;
	case 5:
#line 52 "Scanner.rl.cs"
	{act = 5;}
	break;
	case 6:
#line 56 "Scanner.rl.cs"
	{act = 6;}
	break;
	case 7:
#line 60 "Scanner.rl.cs"
	{act = 7;}
	break;
	case 8:
#line 34 "Scanner.rl.cs"
	{te = p+1;{token( Token.TK_Slit );}}
	break;
	case 9:
#line 36 "Scanner.rl.cs"
	{te = p+1;{token( Token.TK_Dlit );}}
	break;
	case 10:
#line 52 "Scanner.rl.cs"
	{te = p+1;{token( Token.TK_Float );}}
	break;
	case 11:
#line 56 "Scanner.rl.cs"
	{te = p+1;{token( Token.TK_IntegerDecimal );}}
	break;
	case 12:
#line 60 "Scanner.rl.cs"
	{te = p+1;{token( Token.TK_IntegerOctal );}}
	break;
	case 13:
#line 64 "Scanner.rl.cs"
	{te = p+1;{token( Token.TK_IntegerHex );}}
	break;
	case 14:
#line 67 "Scanner.rl.cs"
	{te = p+1;{token( Token.TK_NameSep );}}
	break;
	case 15:
#line 68 "Scanner.rl.cs"
	{te = p+1;{token( Token.TK_EqualsEquals );}}
	break;
	case 16:
#line 69 "Scanner.rl.cs"
	{te = p+1;{token( Token.TK_NotEquals );}}
	break;
	case 17:
#line 70 "Scanner.rl.cs"
	{te = p+1;{token( Token.TK_AndAnd );}}
	break;
	case 18:
#line 71 "Scanner.rl.cs"
	{te = p+1;{token( Token.TK_OrOr );}}
	break;
	case 19:
#line 72 "Scanner.rl.cs"
	{te = p+1;{token( Token.TK_MultAssign );}}
	break;
	case 20:
#line 73 "Scanner.rl.cs"
	{te = p+1;{token( Token.TK_DivAssign );}}
	break;
	case 21:
#line 74 "Scanner.rl.cs"
	{te = p+1;{token( Token.TK_PercentAssign );}}
	break;
	case 22:
#line 75 "Scanner.rl.cs"
	{te = p+1;{token( Token.TK_PlusAssign );}}
	break;
	case 23:
#line 76 "Scanner.rl.cs"
	{te = p+1;{token( Token.TK_MinusAssign );}}
	break;
	case 24:
#line 77 "Scanner.rl.cs"
	{te = p+1;{token( Token.TK_AmpAssign );}}
	break;
	case 25:
#line 78 "Scanner.rl.cs"
	{te = p+1;{token( Token.TK_CaretAssign );}}
	break;
	case 26:
#line 79 "Scanner.rl.cs"
	{te = p+1;{token( Token.TK_BarAssign );}}
	break;
	case 27:
#line 80 "Scanner.rl.cs"
	{te = p+1;{token( Token.TK_PlusPlus );}}
	break;
	case 28:
#line 81 "Scanner.rl.cs"
	{te = p+1;{token( Token.TK_MinusMinus );}}
	break;
	case 29:
#line 83 "Scanner.rl.cs"
	{te = p+1;{token( Token.TK_ArrowStar );}}
	break;
	case 30:
#line 84 "Scanner.rl.cs"
	{te = p+1;{token( Token.TK_DotStar );}}
	break;
	case 31:
#line 85 "Scanner.rl.cs"
	{te = p+1;{line++;col=1;}}
	break;
	case 32:
#line 87 "Scanner.rl.cs"
	{te = p+1;{token( Token.TK_DotDotDot );}}
	break;
	case 33:
#line 90 "Scanner.rl.cs"
	{te = p+1;{token( Token.TK_SingleChar );}}
	break;
	case 34:
#line 92 "Scanner.rl.cs"
	{te = p+1;{token(Token.TK_AdapterExport);}}
	break;
	case 35:
#line 95 "Scanner.rl.cs"
	{te = p+1;{token(Token.TK_BeginEnd);}}
	break;
	case 36:
#line 96 "Scanner.rl.cs"
	{te = p+1;{token(Token.TK_TOP);}}
	break;
	case 37:
#line 97 "Scanner.rl.cs"
	{te = p+1;{token(Token.TK_BOTTOM);}}
	break;
	case 38:
#line 98 "Scanner.rl.cs"
	{te = p+1;{token(Token.TK_Comment);}}
	break;
	case 39:
#line 99 "Scanner.rl.cs"
	{te = p+1;{token(Token.TK_Comment);}}
	break;
	case 40:
#line 100 "Scanner.rl.cs"
	{te = p+1;{token(Token.TK_Comment);}}
	break;
	case 41:
#line 44 "Scanner.rl.cs"
	{te = p;p--;{token( Token.TK_Id );}}
	break;
	case 42:
#line 48 "Scanner.rl.cs"
	{te = p;p--;{ token(Token.TK_Date); }}
	break;
	case 43:
#line 52 "Scanner.rl.cs"
	{te = p;p--;{token( Token.TK_Float );}}
	break;
	case 44:
#line 56 "Scanner.rl.cs"
	{te = p;p--;{token( Token.TK_IntegerDecimal );}}
	break;
	case 45:
#line 60 "Scanner.rl.cs"
	{te = p;p--;{token( Token.TK_IntegerOctal );}}
	break;
	case 46:
#line 64 "Scanner.rl.cs"
	{te = p;p--;{token( Token.TK_IntegerHex );}}
	break;
	case 47:
#line 82 "Scanner.rl.cs"
	{te = p;p--;{token( Token.TK_Arrow );}}
	break;
	case 48:
#line 90 "Scanner.rl.cs"
	{te = p;p--;{token( Token.TK_SingleChar );}}
	break;
	case 49:
#line 99 "Scanner.rl.cs"
	{te = p;p--;{token(Token.TK_Comment);}}
	break;
	case 50:
#line 102 "Scanner.rl.cs"
	{te = p;p--;{token(Token.TK_Whitespace);}}
	break;
	case 51:
#line 44 "Scanner.rl.cs"
	{{p = ((te))-1;}{token( Token.TK_Id );}}
	break;
	case 52:
#line 52 "Scanner.rl.cs"
	{{p = ((te))-1;}{token( Token.TK_Float );}}
	break;
	case 53:
#line 56 "Scanner.rl.cs"
	{{p = ((te))-1;}{token( Token.TK_IntegerDecimal );}}
	break;
	case 54:
#line 90 "Scanner.rl.cs"
	{{p = ((te))-1;}{token( Token.TK_SingleChar );}}
	break;
	case 55:
#line 99 "Scanner.rl.cs"
	{{p = ((te))-1;}{token(Token.TK_Comment);}}
	break;
	case 56:
#line 1 "NONE"
	{	switch( act ) {
	case 0:
	{{cs = 0; if (true) goto _again;}}
	break;
	case 3:
	{{p = ((te))-1;}token( Token.TK_Id );}
	break;
	case 5:
	{{p = ((te))-1;}token( Token.TK_Float );}
	break;
	case 6:
	{{p = ((te))-1;}token( Token.TK_IntegerDecimal );}
	break;
	case 7:
	{{p = ((te))-1;}token( Token.TK_IntegerOctal );}
	break;
	}
	}
	break;
#line 740 "E:\\src\\public\\RagelP\\src\\RagelPLib\\Scanner.rl.g.cs"
		default: break;
		}
	}

_again:
	_acts = _CppScanner_to_state_actions[cs];
	_nacts = _CppScanner_actions[_acts++];
	while ( _nacts-- > 0 ) {
		switch ( _CppScanner_actions[_acts++] ) {
	case 0:
#line 1 "NONE"
	{ts = -1;}
	break;
	case 1:
#line 1 "NONE"
	{act = 0;}
	break;
#line 755 "E:\\src\\public\\RagelP\\src\\RagelPLib\\Scanner.rl.g.cs"
		default: break;
		}
	}

	if ( cs == 0 )
		goto _out;
	if ( ++p != pe )
		goto _resume;
	_test_eof: {}
	if ( p == eof )
	{
	if ( _CppScanner_eof_trans[cs] > 0 ) {
		_trans = (short) (_CppScanner_eof_trans[cs] - 1);
		goto _eof_trans;
	}
	}

	_out: {}
	}

#line 129 "Scanner.rl.cs"
	    }

       
public void resolve()
{
    //DoResolveInheritance();
}
        public LinkedList<TokenData> list() { return _list; }

	    public LinkedListNode<TokenData> finish( )
        {
            _list.AddLast(new TokenData{ TokenType = Token.TK_EOF });
            return _list.First;
	    }       
    }
}
