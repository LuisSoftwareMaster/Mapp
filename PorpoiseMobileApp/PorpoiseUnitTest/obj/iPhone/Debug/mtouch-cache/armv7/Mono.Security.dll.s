.subsections_via_symbols
.section __DWARF, __debug_line,regular,debug
Ldebug_line_section_start:
Ldebug_line_start:
.section __DWARF, __debug_abbrev,regular,debug

	.byte 1,17,1,37,8,3,8,27,8,19,11,17,1,18,1,16,6,0,0,2,46,1,3,8,135,64,8,58,15,59,15,17
	.byte 1,18,1,64,10,0,0,3,5,0,3,8,73,19,2,10,0,0,15,5,0,3,8,73,19,2,6,0,0,4,36,0
	.byte 11,11,62,11,3,8,0,0,5,2,1,3,8,11,15,0,0,17,2,0,3,8,11,15,0,0,6,13,0,3,8,73
	.byte 19,56,10,0,0,7,22,0,3,8,73,19,0,0,8,4,1,3,8,11,15,73,19,0,0,9,40,0,3,8,28,13
	.byte 0,0,10,57,1,3,8,0,0,11,52,0,3,8,73,19,2,10,0,0,12,52,0,3,8,73,19,2,6,0,0,13
	.byte 15,0,73,19,0,0,14,16,0,73,19,0,0,16,28,0,73,19,56,10,0,0,18,46,0,3,8,17,1,18,1,0
	.byte 0,0
.section __DWARF, __debug_info,regular,debug
Ldebug_info_start:

LDIFF_SYM0=Ldebug_info_end - Ldebug_info_begin
	.long LDIFF_SYM0
Ldebug_info_begin:

	.short 2
	.long 0
	.byte 4,1
	.asciz "Mono AOT Compiler 5.0.0 (tarball Fri May  5 18:00:26 EDT 2017)"
	.asciz "Mono.Security.dll"
	.asciz ""

	.byte 2,0,0,0,0,0,0,0,0
LDIFF_SYM1=Ldebug_line_start - Ldebug_line_section_start
	.long LDIFF_SYM1
LDIE_I1:

	.byte 4,1,5
	.asciz "sbyte"
LDIE_U1:

	.byte 4,1,7
	.asciz "byte"
LDIE_I2:

	.byte 4,2,5
	.asciz "short"
LDIE_U2:

	.byte 4,2,7
	.asciz "ushort"
LDIE_I4:

	.byte 4,4,5
	.asciz "int"
LDIE_U4:

	.byte 4,4,7
	.asciz "uint"
LDIE_I8:

	.byte 4,8,5
	.asciz "long"
LDIE_U8:

	.byte 4,8,7
	.asciz "ulong"
LDIE_I:

	.byte 4,4,5
	.asciz "intptr"
LDIE_U:

	.byte 4,4,7
	.asciz "uintptr"
LDIE_R4:

	.byte 4,4,4
	.asciz "float"
LDIE_R8:

	.byte 4,8,4
	.asciz "double"
LDIE_BOOLEAN:

	.byte 4,1,2
	.asciz "boolean"
LDIE_CHAR:

	.byte 4,2,8
	.asciz "char"
LDIE_STRING:

	.byte 4,4,1
	.asciz "string"
LDIE_OBJECT:

	.byte 4,4,1
	.asciz "object"
LDIE_SZARRAY:

	.byte 4,4,1
	.asciz "object"
.section __DWARF, __debug_loc,regular,debug
Ldebug_loc_start:
.section __DWARF, __debug_frame,regular,debug
	.align 3

LDIFF_SYM2=Lcie0_end - Lcie0_start
	.long LDIFF_SYM2
Lcie0_start:

	.long -1
	.byte 3
	.asciz ""

	.byte 1,124,14,12,13,0
	.align 2
Lcie0_end:
.text
	.align 3
jit_code_start:

	.byte 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
.text
	.align 2
	.no_dead_strip Mono_Security_ASN1__ctor_byte_byte__
Mono_Security_ASN1__ctor_byte_byte__:
.file 1 "/Library/Frameworks/Xamarin.iOS.framework/Versions/10.10.0.33/src/mono/mcs/class/Mono.Security/Mono.Security/ASN1.cs"
.loc 1 60 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,64,1,45,233,2,223,77,226,0,96,160,225,0,16,205,229,4,32,141,229,0,0,221,229
	.byte 16,0,198,229
.loc 1 61 0

	.byte 4,0,157,229,8,0,134,229,2,15,134,226
bl _p_1

	.byte 4,0,157,229
.loc 1 62 0

	.byte 2,223,141,226,64,1,189,232,128,128,189,232

Lme_0:
.text
	.align 2
	.no_dead_strip Mono_Security_ASN1__ctor_byte__
Mono_Security_ASN1__ctor_byte__:
.loc 1 66 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,112,13,45,233,6,223,77,226,13,176,160,225,0,96,160,225,12,16,139,229,0,15,160,227
	.byte 8,0,139,229,12,0,155,229,12,16,144,229,0,15,81,227,72,0,0,155,16,16,208,229,16,16,198,229
.loc 1 68 0

	.byte 0,79,160,227
.loc 1 69 0

	.byte 12,16,144,229,64,3,81,227,66,0,0,155,17,160,208,229
.loc 1 71 0

	.byte 10,0,160,225,32,15,80,227,18,0,0,218
.loc 1 73 0

	.byte 32,79,74,226
.loc 1 74 0

	.byte 0,175,160,227
.loc 1 75 0

	.byte 0,95,160,227,11,0,0,234
.loc 1 76 0

	.byte 10,164,160,225
.loc 1 77 0

	.byte 10,0,160,225,128,35,133,226,12,16,155,229,12,48,145,229,2,0,83,225,51,0,0,155,2,16,129,224,4,31,129,226
	.byte 0,16,209,229,1,160,128,224
.loc 1 75 0

	.byte 64,83,133,226,4,0,85,225,241,255,255,186,1,0,0,234
.loc 1 80 0

	.byte 32,15,90,227,30,0,0,10
.loc 1 85 0

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_Mono_Security_got - . + 92
	.byte 0,0,159,231,10,16,160,225
bl _p_2

	.byte 16,0,139,229,8,0,134,229,2,15,134,226
bl _p_1

	.byte 16,0,155,229
.loc 1 86 0

	.byte 128,19,132,226,8,32,150,229,12,0,155,229,0,63,160,227,0,160,141,229
bl _p_3
.loc 1 88 0

	.byte 16,0,214,229,8,15,0,226,8,15,80,227,6,0,0,26
.loc 1 89 0

	.byte 128,3,132,226,8,0,139,229
.loc 1 90 0

	.byte 2,47,139,226,12,16,155,229,12,48,145,229,6,0,160,225
bl _p_4
.loc 1 92 0

	.byte 6,223,139,226,112,13,189,232,128,128,189,232
.loc 1 82 0

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_Mono_Security_got - . -12
	.byte 0,0,159,231,64,19,160,227
bl _p_5

	.byte 0,16,160,225,186,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_6

	.byte 14,16,160,225,0,0,159,229
bl _p_7

	.byte 168,0,0,0

Lme_1:
.text
	.align 2
	.no_dead_strip Mono_Security_ASN1_get_Count
Mono_Security_ASN1_get_Count:
.loc 1 96 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,0,0,157,229,12,0,144,229,0,15,80,227
	.byte 1,0,0,26
.loc 1 97 0

	.byte 0,15,160,227,5,0,0,234
.loc 1 98 0

	.byte 0,0,157,229,12,16,144,229,1,0,160,225,0,16,145,229,15,224,160,225,120,240,145,229,3,223,141,226,0,1,189,232
	.byte 128,128,189,232

Lme_2:
.text
	.align 2
	.no_dead_strip Mono_Security_ASN1_get_Tag
Mono_Security_ASN1_get_Tag:
.loc 1 103 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,0,0,157,229,16,0,208,229,3,223,141,226
	.byte 0,1,189,232,128,128,189,232

Lme_3:
.text
	.align 2
	.no_dead_strip Mono_Security_ASN1_get_Value
Mono_Security_ASN1_get_Value:
.loc 1 117 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,160,160,225,8,0,154,229,0,15,80,227,3,0,0,26
.loc 1 118 0

	.byte 10,0,160,225,0,16,154,229,15,224,160,225,52,240,145,229
.loc 1 119 0

	.byte 8,16,154,229,1,0,160,225,0,224,209,229
bl _p_8

	.byte 0,96,160,225,0,15,86,227,16,0,0,10,0,0,150,229,0,0,144,229,14,16,208,229,64,3,81,227,15,0,0,27
	.byte 4,0,144,229,8,0,144,229,8,0,144,229,0,16,159,229,0,0,0,234
	.long mono_aot_Mono_Security_got - . + 96
	.byte 1,16,159,231,1,0,80,225,6,0,0,27,8,0,150,229,0,15,80,227,3,0,0,27,6,0,160,225,1,223,141,226
	.byte 64,5,189,232,128,128,189,232,14,16,160,225,0,0,159,229
bl _p_7

	.byte 172,0,0,0

Lme_4:
.text
	.align 2
	.no_dead_strip Mono_Security_ASN1_Add_Mono_Security_ASN1
Mono_Security_ASN1_Add_Mono_Security_ASN1:
.loc 1 151 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,5,223,77,226,0,96,160,225,1,160,160,225,0,15,90,227,31,0,0,10
.loc 1 152 0

	.byte 12,0,150,229,0,15,80,227,22,0,0,26
.loc 1 153 0

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_Mono_Security_got - . + 100
	.byte 0,0,159,231,5,31,160,227
bl _p_9

	.byte 0,16,159,229,0,0,0,234
	.long mono_aot_Mono_Security_got - . + 104
	.byte 1,16,159,231,0,16,145,229,8,16,141,229,8,16,128,229,4,0,141,229,2,15,128,226
bl _p_1

	.byte 4,0,157,229,8,16,157,229,0,0,141,229,12,0,134,229,3,15,134,226
bl _p_1

	.byte 0,0,157,229
.loc 1 154 0

	.byte 12,32,150,229,2,0,160,225,10,16,160,225,0,32,146,229,15,224,160,225,112,240,146,229
.loc 1 156 0

	.byte 10,0,160,225,5,223,141,226,64,5,189,232,128,128,189,232

Lme_5:
.text
	.align 2
	.no_dead_strip Mono_Security_ASN1_GetBytes
Mono_Security_ASN1_GetBytes:
.loc 1 161 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,112,13,45,233,22,223,77,226,13,176,160,225,72,0,139,229,0,15,160,227,16,0,139,229
	.byte 0,15,160,227,24,0,139,229,0,15,160,227,8,0,139,229
.loc 1 163 0

	.byte 72,0,155,229
bl _p_10

	.byte 0,15,80,227,197,0,0,218
.loc 1 164 0

	.byte 0,15,160,227,12,0,139,229
.loc 1 165 0

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_Mono_Security_got - . + 100
	.byte 0,0,159,231,5,31,160,227
bl _p_9

	.byte 0,16,159,229,0,0,0,234
	.long mono_aot_Mono_Security_got - . + 104
	.byte 1,16,159,231,0,16,145,229,84,16,139,229,8,16,128,229,80,0,139,229,2,15,128,226
bl _p_1

	.byte 80,0,155,229,84,16,155,229,0,160,160,225
.loc 1 166 0

	.byte 72,0,155,229,12,16,144,229,1,0,160,225,0,16,145,229,15,224,160,225,100,240,145,229,16,0,139,229,38,0,0,234
	.byte 16,16,155,229,1,0,160,225,0,16,145,229,0,128,159,229,0,0,0,234
	.long mono_aot_Mono_Security_got - . + 108
	.byte 8,128,159,231,15,224,160,225,16,240,17,229,52,0,139,229,0,15,80,227,10,0,0,10,52,0,155,229,0,0,144,229
	.byte 0,0,144,229,8,0,144,229,4,0,144,229,0,16,159,229,0,0,0,234
	.long mono_aot_Mono_Security_got - . + 112
	.byte 1,16,159,231,1,0,80,225,88,1,0,27,52,16,155,229
.loc 1 167 0

	.byte 1,0,160,225,0,16,145,229,15,224,160,225,52,240,145,229,20,0,139,229
.loc 1 168 0

	.byte 10,0,160,225,20,16,155,229,0,32,154,229,15,224,160,225,112,240,146,229
.loc 1 169 0

	.byte 20,0,155,229,12,16,144,229,12,0,155,229,1,0,128,224,12,0,139,229
.loc 1 166 0

	.byte 16,16,155,229,1,0,160,225,0,16,145,229,0,128,159,229,0,0,0,234
	.long mono_aot_Mono_Security_got - . + 116
	.byte 8,128,159,231,15,224,160,225,60,240,17,229,255,0,0,226,0,15,80,227,204,255,255,26,0,0,0,235,52,0,0,234
	.byte 2,223,77,226,48,224,139,229,16,0,155,229,56,0,139,229,68,0,139,229,56,0,155,229,0,15,80,227,28,0,0,10
	.byte 56,0,155,229,0,0,144,229,64,0,139,229,20,0,144,229,0,16,159,229,0,0,0,234
	.long mono_aot_Mono_Security_got - . + 120
	.byte 1,16,159,231,1,0,80,225,14,0,0,58,64,0,155,229,16,0,144,229,0,16,159,229,0,0,0,234
	.long mono_aot_Mono_Security_got - . + 120
	.byte 1,16,159,231,193,33,160,225,2,0,128,224,0,0,208,229,112,34,1,226,64,19,160,227,17,18,160,225,1,0,0,224
	.byte 0,15,80,227,3,0,0,26,255,255,255,234,0,15,160,227,68,0,139,229,255,255,255,234,68,0,155,229,24,0,139,229
	.byte 0,15,80,227,8,0,0,10,24,16,155,229,1,0,160,225,0,16,145,229,0,128,159,229,0,0,0,234
	.long mono_aot_Mono_Security_got - . + 124
	.byte 8,128,159,231,15,224,160,225,20,240,17,229,2,223,141,226,48,192,155,229,12,240,160,225
.loc 1 171 0

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_Mono_Security_got - . + 92
	.byte 0,0,159,231,12,16,155,229
bl _p_2

	.byte 8,0,139,229
.loc 1 172 0

	.byte 0,79,160,227
.loc 1 173 0

	.byte 0,15,160,227,28,0,139,229,40,0,0,234
.loc 1 174 0

	.byte 10,0,160,225,28,16,155,229,0,32,154,229,15,224,160,225,116,240,146,229,60,0,139,229,0,15,80,227,17,0,0,10
	.byte 60,0,155,229,0,16,144,229,0,16,145,229,14,32,209,229,64,3,82,227,236,0,0,27,4,16,145,229,8,16,145,229
	.byte 8,16,145,229,0,32,159,229,0,0,0,234
	.long mono_aot_Mono_Security_got - . + 96
	.byte 2,32,159,231,2,0,81,225,227,0,0,27,8,0,144,229,0,15,80,227,224,0,0,27,60,0,155,229,32,0,139,229
.loc 1 175 0

	.byte 0,16,160,225,12,192,145,229,0,31,160,227,8,32,155,229,4,48,160,225,0,192,141,229
bl _p_3
.loc 1 176 0

	.byte 32,0,155,229,12,0,144,229,0,64,132,224
.loc 1 173 0

	.byte 28,0,155,229,64,3,128,226,28,0,139,229,72,0,155,229,12,16,144,229,1,0,160,225,0,16,145,229,15,224,160,225
	.byte 120,240,145,229,0,16,160,225,28,0,155,229,1,0,80,225,204,255,255,186,6,0,0,234
.loc 1 178 0

	.byte 72,0,155,229,8,0,144,229,0,15,80,227,2,0,0,10
.loc 1 179 0

	.byte 72,0,155,229,8,0,144,229,8,0,139,229
.loc 1 183 0

	.byte 0,95,160,227
.loc 1 185 0

	.byte 8,0,155,229,0,15,80,227,162,0,0,10
.loc 1 186 0

	.byte 8,0,155,229,12,0,144,229,36,0,139,229
.loc 1 188 0

	.byte 127,16,0,227,1,0,80,225,129,0,0,218
.loc 1 189 0

	.byte 36,0,155,229,255,16,0,227,1,0,80,225,21,0,0,202
.loc 1 190 0

	.byte 36,0,155,229,192,19,128,226,0,0,159,229,0,0,0,234
	.long mono_aot_Mono_Security_got - . + 92
	.byte 0,0,159,231
bl _p_2

	.byte 0,96,160,225
.loc 1 191 0

	.byte 8,0,155,229,0,31,160,227,6,32,160,225,192,51,160,227,36,192,155,229,0,192,141,229
bl _p_3
.loc 1 192 0

	.byte 129,80,0,227
.loc 1 193 0

	.byte 12,0,150,229,128,3,80,227,154,0,0,155,36,0,155,229,18,0,198,229
.loc 1 194 0

	.byte 119,0,0,234
.loc 1 195 0

	.byte 36,0,155,229,255,31,15,227,1,0,80,225,26,0,0,202
.loc 1 196 0

	.byte 36,0,155,229,1,31,128,226,0,0,159,229,0,0,0,234
	.long mono_aot_Mono_Security_got - . + 92
	.byte 0,0,159,231
bl _p_2

	.byte 0,96,160,225
.loc 1 197 0

	.byte 8,0,155,229,0,31,160,227,6,32,160,225,1,63,160,227,36,192,155,229,0,192,141,229
bl _p_3
.loc 1 198 0

	.byte 130,80,0,227
.loc 1 199 0

	.byte 36,0,155,229,64,20,160,225,12,32,150,229,128,3,82,227,126,0,0,155,18,16,198,229
.loc 1 200 0

	.byte 12,16,150,229,192,3,81,227,122,0,0,155,19,0,198,229
.loc 1 201 0

	.byte 88,0,0,234
.loc 1 202 0

	.byte 36,0,155,229,255,20,224,227,1,0,80,225,31,0,0,202
.loc 1 204 0

	.byte 36,0,155,229,80,18,128,226,0,0,159,229,0,0,0,234
	.long mono_aot_Mono_Security_got - . + 92
	.byte 0,0,159,231
bl _p_2

	.byte 0,96,160,225
.loc 1 205 0

	.byte 8,0,155,229,0,31,160,227,6,32,160,225,80,50,160,227,36,192,155,229,0,192,141,229
bl _p_3
.loc 1 206 0

	.byte 131,80,0,227
.loc 1 207 0

	.byte 36,0,155,229,64,24,160,225,12,32,150,229,128,3,82,227,95,0,0,155,18,16,198,229
.loc 1 208 0

	.byte 64,20,160,225,12,32,150,229,192,3,82,227,90,0,0,155,19,16,198,229
.loc 1 209 0

	.byte 12,16,150,229,1,15,81,227,86,0,0,155,20,0,198,229
.loc 1 210 0

	.byte 52,0,0,234
.loc 1 213 0

	.byte 36,0,155,229,96,18,128,226,0,0,159,229,0,0,0,234
	.long mono_aot_Mono_Security_got - . + 92
	.byte 0,0,159,231
bl _p_2

	.byte 0,96,160,225
.loc 1 214 0

	.byte 8,0,155,229,0,31,160,227,6,32,160,225,96,50,160,227,36,192,155,229,0,192,141,229
bl _p_3
.loc 1 215 0

	.byte 33,95,160,227
.loc 1 216 0

	.byte 36,0,155,229,64,28,160,225,12,32,150,229,128,3,82,227,63,0,0,155,18,16,198,229
.loc 1 217 0

	.byte 64,24,160,225,12,32,150,229,192,3,82,227,58,0,0,155,19,16,198,229
.loc 1 218 0

	.byte 64,20,160,225,12,32,150,229,1,15,82,227,53,0,0,155,20,16,198,229
.loc 1 219 0

	.byte 12,16,150,229,80,2,81,227,49,0,0,155,21,0,198,229
.loc 1 221 0

	.byte 15,0,0,234
.loc 1 224 0

	.byte 36,0,155,229,128,19,128,226,0,0,159,229,0,0,0,234
	.long mono_aot_Mono_Security_got - . + 92
	.byte 0,0,159,231
bl _p_2

	.byte 0,96,160,225
.loc 1 225 0

	.byte 8,0,155,229,0,31,160,227,6,32,160,225,128,51,160,227,36,192,155,229,0,192,141,229
bl _p_3
.loc 1 226 0

	.byte 36,80,155,229
.loc 1 228 0

	.byte 72,0,155,229,8,0,144,229,0,15,80,227,13,0,0,26
.loc 1 229 0

	.byte 8,16,155,229,72,0,155,229,8,16,128,229,2,15,128,226
bl _p_1

	.byte 8,0,155,229
.loc 1 230 0

	.byte 6,0,0,234
.loc 1 232 0

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_Mono_Security_got - . + 92
	.byte 0,0,159,231,128,19,160,227
bl _p_2

	.byte 0,96,160,225
.loc 1 234 0

	.byte 72,0,155,229,16,0,208,229,12,16,150,229,0,15,81,227,8,0,0,155,16,0,198,229
.loc 1 235 0

	.byte 12,0,150,229,64,3,80,227,4,0,0,155,17,80,198,229
.loc 1 237 0

	.byte 6,0,160,225,22,223,139,226,112,13,189,232,128,128,189,232,14,16,160,225,0,0,159,229
bl _p_7

	.byte 168,0,0,0,14,16,160,225,0,0,159,229
bl _p_7

	.byte 172,0,0,0

Lme_6:
.text
	.align 2
	.no_dead_strip Mono_Security_ASN1_Decode_byte___int__int
Mono_Security_ASN1_Decode_byte___int__int:
.loc 1 0 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,112,13,45,233,12,223,77,226,13,176,160,225,0,64,160,225,1,80,160,225,2,96,160,225
	.byte 24,48,139,229,0,15,160,227,8,0,203,229,0,15,160,227,12,0,139,229,0,15,160,227,16,0,139,229,0,15,160,227
	.byte 20,0,139,229,49,0,0,234
.loc 1 249 0

	.byte 2,63,139,226,3,15,139,226,4,207,139,226,4,16,160,225,32,16,139,229,5,16,160,225,6,32,160,225,0,0,141,229
	.byte 32,0,155,229,4,192,141,229
bl _p_11
.loc 1 251 0

	.byte 8,0,219,229,0,15,80,227,35,0,0,10
.loc 1 254 0

	.byte 8,0,219,229,36,0,139,229,16,0,155,229,40,0,139,229,0,0,159,229,0,0,0,234
	.long mono_aot_Mono_Security_got - . + 128
	.byte 0,0,159,231,5,31,160,227
bl _p_9

	.byte 36,16,155,229,40,32,155,229,32,0,139,229
bl _p_12

	.byte 32,16,155,229,4,0,160,225
bl _p_13

	.byte 0,160,160,225
.loc 1 256 0

	.byte 8,0,219,229,8,15,0,226,8,15,80,227,9,0,0,26
.loc 1 257 0

	.byte 0,0,150,229,20,0,139,229
.loc 1 258 0

	.byte 5,47,139,226,20,0,155,229,12,16,155,229,1,48,128,224,10,0,160,225,5,16,160,225,0,224,218,229
bl _p_4
.loc 1 260 0

	.byte 0,0,150,229,12,16,155,229,1,0,128,224,0,0,134,229
.loc 1 248 0

	.byte 0,0,150,229,24,16,155,229,64,19,65,226,1,0,80,225,200,255,255,186
.loc 1 262 0

	.byte 12,223,139,226,112,13,189,232,128,128,189,232

Lme_7:
.text
	.align 2
	.no_dead_strip Mono_Security_ASN1_DecodeTLV_byte___int__byte__int__byte___
Mono_Security_ASN1_DecodeTLV_byte___int__byte__int__byte___:
.loc 1 267 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,80,13,45,233,11,223,77,226,13,176,160,225,16,0,139,229,1,160,160,225,2,64,160,225
	.byte 20,48,139,229,72,224,157,229,24,224,139,229,76,224,157,229,28,224,139,229,0,96,148,229,6,0,160,225,64,3,128,226
	.byte 0,0,132,229,12,0,154,229,6,0,80,225,77,0,0,155,6,0,138,224,4,15,128,226,0,16,208,229,20,0,155,229
	.byte 0,16,192,229
.loc 1 268 0

	.byte 0,96,148,229,6,0,160,225,64,3,128,226,0,0,132,229,12,0,154,229,6,0,80,225,65,0,0,155,6,0,138,224
	.byte 4,15,128,226,0,16,208,229,24,0,155,229,0,16,128,229
.loc 1 271 0

	.byte 1,0,160,225,32,15,0,226,32,15,80,227,31,0,0,26
.loc 1 272 0

	.byte 24,0,155,229,0,16,144,229,127,32,0,227,2,16,1,224,8,16,139,229
.loc 1 273 0

	.byte 0,31,160,227,0,16,128,229
.loc 1 274 0

	.byte 0,15,160,227,12,0,139,229,17,0,0,234
.loc 1 275 0

	.byte 24,0,155,229,0,16,144,229,1,20,160,225,0,96,148,229,6,32,160,225,64,35,130,226,0,32,132,229,12,32,154,229
	.byte 6,0,82,225,36,0,0,155,6,32,138,224,4,47,130,226,0,32,210,229,2,16,129,224,0,16,128,229
.loc 1 274 0

	.byte 12,0,155,229,64,3,128,226,12,0,139,229,12,0,155,229,8,16,155,229,1,0,80,225,233,255,255,186
.loc 1 278 0

	.byte 24,0,155,229,0,16,144,229,0,0,159,229,0,0,0,234
	.long mono_aot_Mono_Security_got - . + 92
	.byte 0,0,159,231
bl _p_2

	.byte 0,16,160,225,28,0,155,229,32,16,139,229,0,16,128,229
bl _p_1

	.byte 32,0,155,229
.loc 1 279 0

	.byte 0,16,148,229,28,0,155,229,0,32,144,229,24,0,155,229,0,192,144,229,10,0,160,225,0,63,160,227,0,192,141,229
bl _p_3
.loc 1 280 0

	.byte 11,223,139,226,80,13,189,232,128,128,189,232,14,16,160,225,0,0,159,229
bl _p_7

	.byte 168,0,0,0

Lme_8:
.text
	.align 2
	.no_dead_strip Mono_Security_ASN1_get_Item_int
Mono_Security_ASN1_get_Item_int:
.loc 1 285 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,64,13,45,233,6,223,77,226,13,176,160,225,0,96,160,225,1,160,160,225,0,15,160,227
	.byte 0,0,139,229,12,0,150,229,0,15,80,227,6,0,0,10,12,16,150,229,1,0,160,225,0,16,145,229,15,224,160,225
	.byte 120,240,145,229,0,0,90,225,2,0,0,186
.loc 1 286 0

	.byte 0,15,160,227,0,0,139,229,30,0,0,234
.loc 1 287 0

	.byte 12,32,150,229,2,0,160,225,10,16,160,225,0,32,146,229,15,224,160,225,116,240,146,229,0,160,160,225,0,15,90,227
	.byte 9,0,0,10,0,0,154,229,0,0,144,229,8,0,144,229,4,0,144,229,0,16,159,229,0,0,0,234
	.long mono_aot_Mono_Security_got - . + 112
	.byte 1,16,159,231,1,0,80,225,16,0,0,27,0,160,139,229,9,0,0,234,4,0,139,229
.loc 1 290 0

	.byte 0,15,160,227,0,0,139,229
bl _p_14

	.byte 20,0,139,229,0,15,80,227,1,0,0,10,20,0,155,229
bl _p_6

	.byte 255,255,255,234
.loc 1 292 0

	.byte 0,0,155,229,255,255,255,234,6,223,139,226,64,13,189,232,128,128,189,232,14,16,160,225,0,0,159,229
bl _p_7

	.byte 172,0,0,0

Lme_9:
.text
	.align 2
	.no_dead_strip Mono_Security_ASN1_ToString
Mono_Security_ASN1_ToString:
.loc 1 314 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,96,5,45,233,20,223,77,226,0,160,160,225,0,0,159,229,0,0,0,234
	.long mono_aot_Mono_Security_got - . + 132
	.byte 0,0,159,231,7,31,160,227
bl _p_9

	.byte 72,0,141,229
bl _p_15

	.byte 72,0,157,229,0,96,160,225
.loc 1 317 0

	.byte 68,0,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_Mono_Security_got - . + 136
	.byte 0,0,159,231,60,0,141,229,0,15,90,227,123,0,0,11,4,15,138,226,0,16,159,229,0,0,0,234
	.long mono_aot_Mono_Security_got - . + 140
	.byte 1,16,159,231
bl _p_16

	.byte 64,0,141,229
bl _p_17

	.byte 0,48,160,225,60,16,157,229,64,32,157,229,68,192,157,229,12,0,160,225,0,224,220,229
bl _p_18
.loc 1 320 0

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_Mono_Security_got - . + 144
	.byte 0,0,159,231,48,0,141,229,10,0,160,225
bl _p_19

	.byte 12,0,144,229,56,0,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_Mono_Security_got - . + 148
	.byte 0,0,159,231,3,31,160,227
bl _p_9

	.byte 56,16,157,229,8,16,128,229,52,0,141,229
bl _p_17

	.byte 0,48,160,225,48,16,157,229,52,32,157,229,6,0,160,225,0,224,214,229
bl _p_18
.loc 1 323 0

	.byte 0,16,159,229,0,0,0,234
	.long mono_aot_Mono_Security_got - . + 152
	.byte 1,16,159,231,6,0,160,225,0,224,214,229
bl _p_20
.loc 1 324 0
bl _p_17

	.byte 0,16,160,225,6,0,160,225,0,224,214,229
bl _p_20
.loc 1 325 0

	.byte 0,95,160,227,53,0,0,234
.loc 1 326 0

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_Mono_Security_got - . + 156
	.byte 0,0,159,231,48,0,141,229,10,0,160,225
bl _p_19

	.byte 12,16,144,229,5,0,81,225,55,0,0,155,5,0,128,224,4,15,128,226,0,16,159,229,0,0,0,234
	.long mono_aot_Mono_Security_got - . + 140
	.byte 1,16,159,231
bl _p_16

	.byte 0,32,160,225,48,16,157,229,6,0,160,225,0,224,214,229
bl _p_21
.loc 1 327 0

	.byte 64,3,133,226,192,31,160,225,33,30,160,225,1,0,128,224,240,2,0,226,1,0,64,224,0,15,80,227,22,0,0,26
.loc 1 328 0
bl _p_17

	.byte 48,0,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_Mono_Security_got - . + 160
	.byte 0,0,159,231,0,0,159,229,0,0,0,234
	.long mono_aot_Mono_Security_got - . + 164
	.byte 0,0,159,231,217,193,208,225,0,0,92,227,0,0,0,26
bl _p_22

	.byte 48,16,157,229,0,0,159,229,0,0,0,234
	.long mono_aot_Mono_Security_got - . + 168
	.byte 0,0,159,231,0,32,144,229,6,0,160,225,0,224,214,229
bl _p_23
.loc 1 325 0

	.byte 64,83,133,226,10,0,160,225
bl _p_19

	.byte 12,0,144,229,0,0,85,225,196,255,255,186
.loc 1 330 0

	.byte 6,0,160,225,0,16,150,229,15,224,160,225,36,240,145,229,20,223,141,226,96,5,189,232,128,128,189,232,14,16,160,225
	.byte 0,0,159,229
bl _p_7

	.byte 168,0,0,0,14,16,160,225,0,0,159,229
bl _p_7

	.byte 187,0,0,0

Lme_a:
.text
	.align 2
	.no_dead_strip wrapper_unknown_byte___Get_int
wrapper_unknown_byte___Get_int:

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,4,16,141,229,0,0,157,229,12,32,144,229
	.byte 4,16,157,229,1,0,82,225,5,0,0,155,1,0,128,224,4,15,128,226,0,0,208,229,3,223,141,226,0,1,189,232
	.byte 128,128,189,232,14,16,160,225,0,0,159,229
bl _p_7

	.byte 168,0,0,0

Lme_c:
.text
	.align 2
	.no_dead_strip wrapper_runtime_invoke__Module_runtime_invoke_byte__this___int_object_intptr_intptr_intptr
wrapper_runtime_invoke__Module_runtime_invoke_byte__this___int_object_intptr_intptr_intptr:

	.byte 128,64,45,233,13,112,160,225,16,9,45,233,13,223,77,226,13,176,160,225,24,0,139,229,28,16,139,229,32,32,139,229
	.byte 36,48,139,229,0,15,160,227,0,0,139,229,0,15,160,227,4,0,139,229,32,0,155,229,0,15,80,227,40,0,0,10
	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_Mono_Security_got - . + 172
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,5,0,0,10
bl _p_24

	.byte 0,64,160,225,0,15,80,227,1,0,0,10,4,0,160,225
bl _p_6

	.byte 28,0,155,229,0,0,144,229,0,16,144,229,24,0,155,229,36,32,155,229,50,255,47,225,40,0,139,229,0,0,159,229
	.byte 0,0,0,234
	.long mono_aot_Mono_Security_got - . + 176
	.byte 0,0,159,231,144,18,160,227
bl _p_9

	.byte 40,16,155,229,8,16,192,229,0,0,139,229,8,0,0,234,8,0,139,229,4,0,139,229,32,0,155,229,4,16,155,229
	.byte 40,16,139,229,0,16,128,229
bl _p_1

	.byte 40,0,155,229,255,255,255,234,0,0,155,229,23,0,0,234,0,0,159,229,0,0,0,234
	.long mono_aot_Mono_Security_got - . + 172
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,19,0,0,26,255,255,255,234,28,0,155,229,0,0,144,229,0,16,144,229
	.byte 24,0,155,229,36,32,155,229,50,255,47,225,40,0,139,229,0,0,159,229,0,0,0,234
	.long mono_aot_Mono_Security_got - . + 176
	.byte 0,0,159,231,144,18,160,227
bl _p_9

	.byte 40,16,155,229,8,16,192,229,0,0,139,229,13,223,139,226,16,9,189,232,128,128,189,232
bl _p_24

	.byte 0,64,160,225,0,15,80,227,232,255,255,10,4,0,160,225
bl _p_6

Lme_d:
.text
	.align 2
	.no_dead_strip wrapper_unknown_byte___Set_int_byte
wrapper_unknown_byte___Set_int_byte:

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,5,223,77,226,0,0,141,229,4,16,141,229,8,32,205,229,0,0,157,229
	.byte 12,32,144,229,4,16,157,229,1,0,82,225,6,0,0,155,1,0,128,224,4,15,128,226,8,16,221,229,0,16,192,229
	.byte 5,223,141,226,0,1,189,232,128,128,189,232,14,16,160,225,0,0,159,229
bl _p_7

	.byte 168,0,0,0

Lme_e:
.text
	.align 2
	.no_dead_strip wrapper_runtime_invoke__Module_runtime_invoke_void__this___int_byte_object_intptr_intptr_intptr
wrapper_runtime_invoke__Module_runtime_invoke_void__this___int_byte_object_intptr_intptr_intptr:

	.byte 128,64,45,233,13,112,160,225,80,9,45,233,12,223,77,226,13,176,160,225,24,0,139,229,1,96,160,225,28,32,139,229
	.byte 32,48,139,229,0,15,160,227,0,0,139,229,0,15,160,227,4,0,139,229,28,0,155,229,0,15,80,227,32,0,0,10
	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_Mono_Security_got - . + 172
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,5,0,0,10
bl _p_24

	.byte 0,64,160,225,0,15,80,227,1,0,0,10,4,0,160,225
bl _p_6

	.byte 0,0,150,229,0,16,144,229,1,15,134,226,0,0,144,229,0,32,208,229,24,0,155,229,32,48,155,229,51,255,47,225
	.byte 8,0,0,234,8,0,139,229,4,0,139,229,28,0,155,229,4,16,155,229,40,16,139,229,0,16,128,229
bl _p_1

	.byte 40,0,155,229,255,255,255,234,0,0,155,229,16,0,0,234,0,0,159,229,0,0,0,234
	.long mono_aot_Mono_Security_got - . + 172
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,12,0,0,26,255,255,255,234,0,0,150,229,0,16,144,229,1,15,134,226
	.byte 0,0,144,229,0,32,208,229,24,0,155,229,32,48,155,229,51,255,47,225,0,0,155,229,12,223,139,226,80,9,189,232
	.byte 128,128,189,232
bl _p_24

	.byte 0,64,160,225,0,15,80,227,239,255,255,10,4,0,160,225
bl _p_6

Lme_f:
.text
	.align 3
jit_code_end:

	.byte 0,0,0,0
.text
	.align 3
method_addresses:
	.no_dead_strip method_addresses
bl Mono_Security_ASN1__ctor_byte_byte__
bl Mono_Security_ASN1__ctor_byte__
bl Mono_Security_ASN1_get_Count
bl Mono_Security_ASN1_get_Tag
bl Mono_Security_ASN1_get_Value
bl Mono_Security_ASN1_Add_Mono_Security_ASN1
bl Mono_Security_ASN1_GetBytes
bl Mono_Security_ASN1_Decode_byte___int__int
bl Mono_Security_ASN1_DecodeTLV_byte___int__byte__int__byte___
bl Mono_Security_ASN1_get_Item_int
bl Mono_Security_ASN1_ToString
bl method_addresses
bl wrapper_unknown_byte___Get_int
bl wrapper_runtime_invoke__Module_runtime_invoke_byte__this___int_object_intptr_intptr_intptr
bl wrapper_unknown_byte___Set_int_byte
bl wrapper_runtime_invoke__Module_runtime_invoke_void__this___int_byte_object_intptr_intptr_intptr
method_addresses_end:

.section __TEXT, __const
	.align 3
unbox_trampolines:
unbox_trampolines_end:

	.long 0
.text
	.align 3
unbox_trampoline_addresses:

	.long 0
.section __TEXT, __const
	.align 3
unwind_info:

	.byte 35,12,13,0,68,14,8,135,2,72,14,16,134,4,136,3,142,1,68,14,24,2,40,10,68,14,16,68,8,6,8,8
	.byte 14,8,68,11,57,12,13,0,68,14,8,135,2,72,14,32,132,8,133,7,134,6,136,5,138,4,139,3,142,1,68,14
	.byte 56,68,13,11,3,12,1,10,68,13,13,14,32,68,8,4,8,5,8,6,8,8,8,10,8,11,14,8,68,11,31,12
	.byte 13,0,68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,2,52,10,68,14,12,68,8,8,14,8,68,11,30,12
	.byte 13,0,68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,76,10,68,14,12,68,8,8,14,8,68,11,39,12,13
	.byte 0,68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,132,10,68,14,20,68,8,6,8,8,8
	.byte 10,14,8,68,11,39,12,13,0,68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,40,2,148,10,68
	.byte 14,20,68,8,6,8,8,8,10,14,8,68,11,57,12,13,0,68,14,8,135,2,72,14,32,132,8,133,7,134,6,136
	.byte 5,138,4,139,3,142,1,68,14,120,68,13,11,3,68,6,10,68,13,13,14,32,68,8,4,8,5,8,6,8,8,8
	.byte 10,8,11,14,8,68,11,57,12,13,0,68,14,8,135,2,72,14,32,132,8,133,7,134,6,136,5,138,4,139,3,142
	.byte 1,68,14,80,68,13,11,3,16,1,10,68,13,13,14,32,68,8,4,8,5,8,6,8,8,8,10,8,11,14,8,68
	.byte 11,53,12,13,0,68,14,8,135,2,72,14,28,132,7,134,6,136,5,138,4,139,3,142,1,68,14,72,68,13,11,3
	.byte 104,1,10,68,13,13,14,28,68,8,4,8,6,8,8,8,10,8,11,14,8,68,11,48,12,13,0,68,14,8,135,2
	.byte 72,14,24,134,6,136,5,138,4,139,3,142,1,68,14,48,68,13,11,2,200,10,68,13,13,14,24,68,8,6,8,8
	.byte 8,10,8,11,14,8,68,11,44,12,13,0,68,14,8,135,2,72,14,24,133,6,134,5,136,4,138,3,142,1,68,14
	.byte 104,3,32,2,10,68,14,24,68,8,5,8,6,8,8,8,10,14,8,68,11,31,12,13,0,68,14,8,135,2,72,14
	.byte 12,136,3,142,1,68,14,24,2,40,10,68,14,12,68,8,8,14,8,68,11,45,12,13,0,68,14,8,135,2,72,14
	.byte 20,132,5,136,4,139,3,142,1,68,14,72,68,13,11,3,48,1,10,68,13,13,14,20,68,8,4,8,8,8,11,14
	.byte 8,68,11,31,12,13,0,68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,2,48,10,68,14,12,68,8,8,14
	.byte 8,68,11,48,12,13,0,68,14,8,135,2,72,14,24,132,6,134,5,136,4,139,3,142,1,68,14,72,68,13,11,2
	.byte 244,10,68,13,13,14,24,68,8,4,8,6,8,8,8,11,14,8,68,11

.text
	.align 4
plt:
mono_aot_Mono_Security_plt:
	.no_dead_strip plt_wrapper_write_barrier_object_wbarrier_conc_intptr
plt_wrapper_write_barrier_object_wbarrier_conc_intptr:
_p_1:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Mono_Security_got - . + 192,485
	.no_dead_strip plt_wrapper_alloc_object_AllocVector_intptr_intptr
plt_wrapper_alloc_object_AllocVector_intptr_intptr:
_p_2:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Mono_Security_got - . + 196,492
	.no_dead_strip plt_System_Buffer_BlockCopy_System_Array_int_System_Array_int_int
plt_System_Buffer_BlockCopy_System_Array_int_System_Array_int_int:
_p_3:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Mono_Security_got - . + 200,500
	.no_dead_strip plt_Mono_Security_ASN1_Decode_byte___int__int
plt_Mono_Security_ASN1_Decode_byte___int__int:
_p_4:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Mono_Security_got - . + 204,503
	.no_dead_strip plt__jit_icall_mono_helper_ldstr
plt__jit_icall_mono_helper_ldstr:
_p_5:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Mono_Security_got - . + 208,508
	.no_dead_strip plt__jit_icall_mono_arch_throw_exception
plt__jit_icall_mono_arch_throw_exception:
_p_6:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Mono_Security_got - . + 212,528
	.no_dead_strip plt__jit_icall_mono_arch_throw_corlib_exception
plt__jit_icall_mono_arch_throw_corlib_exception:
_p_7:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Mono_Security_got - . + 216,556
	.no_dead_strip plt_System_Array_Clone
plt_System_Array_Clone:
_p_8:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Mono_Security_got - . + 220,591
	.no_dead_strip plt_wrapper_alloc_object_AllocSmall_intptr_intptr
plt_wrapper_alloc_object_AllocSmall_intptr_intptr:
_p_9:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Mono_Security_got - . + 224,594
	.no_dead_strip plt_Mono_Security_ASN1_get_Count
plt_Mono_Security_ASN1_get_Count:
_p_10:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Mono_Security_got - . + 228,602
	.no_dead_strip plt_Mono_Security_ASN1_DecodeTLV_byte___int__byte__int__byte___
plt_Mono_Security_ASN1_DecodeTLV_byte___int__byte__int__byte___:
_p_11:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Mono_Security_got - . + 232,607
	.no_dead_strip plt_Mono_Security_ASN1__ctor_byte_byte__
plt_Mono_Security_ASN1__ctor_byte_byte__:
_p_12:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Mono_Security_got - . + 236,612
	.no_dead_strip plt_Mono_Security_ASN1_Add_Mono_Security_ASN1
plt_Mono_Security_ASN1_Add_Mono_Security_ASN1:
_p_13:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Mono_Security_got - . + 240,617
	.no_dead_strip plt__jit_icall_mono_thread_get_undeniable_exception
plt__jit_icall_mono_thread_get_undeniable_exception:
_p_14:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Mono_Security_got - . + 244,622
	.no_dead_strip plt_System_Text_StringBuilder__ctor
plt_System_Text_StringBuilder__ctor:
_p_15:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Mono_Security_got - . + 248,661
	.no_dead_strip plt_byte_ToString_string
plt_byte_ToString_string:
_p_16:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Mono_Security_got - . + 252,664
	.no_dead_strip plt_System_Environment_get_NewLine
plt_System_Environment_get_NewLine:
_p_17:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Mono_Security_got - . + 256,667
	.no_dead_strip plt_System_Text_StringBuilder_AppendFormat_string_object_object
plt_System_Text_StringBuilder_AppendFormat_string_object_object:
_p_18:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Mono_Security_got - . + 260,670
	.no_dead_strip plt_Mono_Security_ASN1_get_Value
plt_Mono_Security_ASN1_get_Value:
_p_19:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Mono_Security_got - . + 264,673
	.no_dead_strip plt_System_Text_StringBuilder_Append_string
plt_System_Text_StringBuilder_Append_string:
_p_20:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Mono_Security_got - . + 268,678
	.no_dead_strip plt_System_Text_StringBuilder_AppendFormat_string_object
plt_System_Text_StringBuilder_AppendFormat_string_object:
_p_21:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Mono_Security_got - . + 272,681
	.no_dead_strip plt__jit_icall_mono_generic_class_init
plt__jit_icall_mono_generic_class_init:
_p_22:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Mono_Security_got - . + 276,684
	.no_dead_strip plt_System_Text_StringBuilder_AppendFormat_string_object__
plt_System_Text_StringBuilder_AppendFormat_string_object__:
_p_23:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Mono_Security_got - . + 280,710
	.no_dead_strip plt__jit_icall_mono_thread_force_interruption_checkpoint_noraise
plt__jit_icall_mono_thread_force_interruption_checkpoint_noraise:
_p_24:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Mono_Security_got - . + 284,713
plt_end:
.section __DATA, __bss
	.align 3
.lcomm mono_aot_Mono_Security_got, 292
got_end:
.section __TEXT, __const
	.align 3
Lglobals_hash:

	.short 11, 0, 0, 0, 0, 0, 0, 0
	.short 0, 0, 0, 0, 0, 0, 0, 0
	.short 0, 0, 0, 0, 0, 0, 0
.data
	.align 3
globals:
	.align 2
	.long Lglobals_hash

	.long 0,0
.section __TEXT, __const
	.align 2
runtime_version:
	.asciz ""
.section __TEXT, __const
	.align 2
assembly_guid:
	.asciz "217FA914-9850-431E-BB3A-019CA113E479"
.section __TEXT, __const
	.align 2
assembly_name:
	.asciz "Mono.Security"
.data
	.align 3
_mono_aot_file_info:

	.long 139,0
	.align 2
	.long mono_aot_Mono_Security_got
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long jit_code_start
	.align 2
	.long jit_code_end
	.align 2
	.long method_addresses
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long mem_end
	.align 2
	.long assembly_guid
	.align 2
	.long runtime_version
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long globals
	.align 2
	.long assembly_name
	.align 2
	.long plt
	.align 2
	.long plt_end
	.align 2
	.long unwind_info
	.align 2
	.long unbox_trampolines
	.align 2
	.long unbox_trampolines_end
	.align 2
	.long unbox_trampoline_addresses

	.long 48,292,25,16,66,391195135,0,3094
	.long 128,4,4,10,0,26,3736,632
	.long 440,232,0,360,416,280,0,192
	.long 48,0,0,0,0,0,0,0
	.long 0,0,0,0,0,0,0,0
	.long 0
	.byte 225,238,233,15,105,70,236,216,228,246,111,105,199,59,1,5
	.globl _mono_aot_module_Mono_Security_info
	.align 2
_mono_aot_module_Mono_Security_info:
	.align 2
	.long _mono_aot_file_info
.section __DWARF, __debug_info,regular,debug
LTDIE_1:

	.byte 17
	.asciz "System_Object"

	.byte 8,7
	.asciz "System_Object"

LDIFF_SYM3=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM3
LTDIE_1_POINTER:

	.byte 13
LDIFF_SYM4=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM4
LTDIE_1_REFERENCE:

	.byte 14
LDIFF_SYM5=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM5
LTDIE_3:

	.byte 5
	.asciz "System_ValueType"

	.byte 8,16
LDIFF_SYM6=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM6
	.byte 2,35,0,0,7
	.asciz "System_ValueType"

LDIFF_SYM7=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM7
LTDIE_3_POINTER:

	.byte 13
LDIFF_SYM8=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM8
LTDIE_3_REFERENCE:

	.byte 14
LDIFF_SYM9=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM9
LTDIE_2:

	.byte 5
	.asciz "System_Byte"

	.byte 9,16
LDIFF_SYM10=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM10
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM11=LDIE_U1 - Ldebug_info_start
	.long LDIFF_SYM11
	.byte 2,35,8,0,7
	.asciz "System_Byte"

LDIFF_SYM12=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM12
LTDIE_2_POINTER:

	.byte 13
LDIFF_SYM13=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM13
LTDIE_2_REFERENCE:

	.byte 14
LDIFF_SYM14=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM14
LTDIE_5:

	.byte 5
	.asciz "System_Int32"

	.byte 12,16
LDIFF_SYM15=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM15
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM16=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM16
	.byte 2,35,8,0,7
	.asciz "System_Int32"

LDIFF_SYM17=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM17
LTDIE_5_POINTER:

	.byte 13
LDIFF_SYM18=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM18
LTDIE_5_REFERENCE:

	.byte 14
LDIFF_SYM19=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM19
LTDIE_4:

	.byte 5
	.asciz "System_Collections_ArrayList"

	.byte 20,16
LDIFF_SYM20=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM20
	.byte 2,35,0,6
	.asciz "_items"

LDIFF_SYM21=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM21
	.byte 2,35,8,6
	.asciz "_size"

LDIFF_SYM22=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM22
	.byte 2,35,12,6
	.asciz "_version"

LDIFF_SYM23=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM23
	.byte 2,35,16,0,7
	.asciz "System_Collections_ArrayList"

LDIFF_SYM24=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM24
LTDIE_4_POINTER:

	.byte 13
LDIFF_SYM25=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM25
LTDIE_4_REFERENCE:

	.byte 14
LDIFF_SYM26=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM26
LTDIE_0:

	.byte 5
	.asciz "Mono_Security_ASN1"

	.byte 20,16
LDIFF_SYM27=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM27
	.byte 2,35,0,6
	.asciz "m_nTag"

LDIFF_SYM28=LDIE_U1 - Ldebug_info_start
	.long LDIFF_SYM28
	.byte 2,35,16,6
	.asciz "m_aValue"

LDIFF_SYM29=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM29
	.byte 2,35,8,6
	.asciz "elist"

LDIFF_SYM30=LTDIE_4_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM30
	.byte 2,35,12,0,7
	.asciz "Mono_Security_ASN1"

LDIFF_SYM31=LTDIE_0 - Ldebug_info_start
	.long LDIFF_SYM31
LTDIE_0_POINTER:

	.byte 13
LDIFF_SYM32=LTDIE_0 - Ldebug_info_start
	.long LDIFF_SYM32
LTDIE_0_REFERENCE:

	.byte 14
LDIFF_SYM33=LTDIE_0 - Ldebug_info_start
	.long LDIFF_SYM33
	.byte 2
	.asciz "Mono.Security.ASN1:.ctor"
	.asciz "Mono_Security_ASN1__ctor_byte_byte__"

	.byte 1,58
	.long Mono_Security_ASN1__ctor_byte_byte__
	.long Lme_0

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM34=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM34
	.byte 1,86,3
	.asciz "tag"

LDIFF_SYM35=LDIE_U1 - Ldebug_info_start
	.long LDIFF_SYM35
	.byte 2,125,0,3
	.asciz "data"

LDIFF_SYM36=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM36
	.byte 2,125,4,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM37=Lfde0_end - Lfde0_start
	.long LDIFF_SYM37
Lfde0_start:

	.long 0
	.align 2
	.long Mono_Security_ASN1__ctor_byte_byte__

LDIFF_SYM38=Lme_0 - Mono_Security_ASN1__ctor_byte_byte__
	.long LDIFF_SYM38
	.byte 68,14,8,135,2,72,14,16,134,4,136,3,142,1,68,14,24,2,40,10,68,14,16,68,8,6,8,8,14,8,68,11
	.align 2
Lfde0_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Mono.Security.ASN1:.ctor"
	.asciz "Mono_Security_ASN1__ctor_byte__"

	.byte 1,64
	.long Mono_Security_ASN1__ctor_byte__
	.long Lme_1

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM39=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM39
	.byte 1,86,3
	.asciz "data"

LDIFF_SYM40=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM40
	.byte 2,123,12,11
	.asciz "nLenLength"

LDIFF_SYM41=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM41
	.byte 1,84,11
	.asciz "nLength"

LDIFF_SYM42=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM42
	.byte 1,90,11
	.asciz "i"

LDIFF_SYM43=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM43
	.byte 1,85,11
	.asciz "nStart"

LDIFF_SYM44=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM44
	.byte 2,123,8,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM45=Lfde1_end - Lfde1_start
	.long LDIFF_SYM45
Lfde1_start:

	.long 0
	.align 2
	.long Mono_Security_ASN1__ctor_byte__

LDIFF_SYM46=Lme_1 - Mono_Security_ASN1__ctor_byte__
	.long LDIFF_SYM46
	.byte 68,14,8,135,2,72,14,32,132,8,133,7,134,6,136,5,138,4,139,3,142,1,68,14,56,68,13,11,3,12,1,10
	.byte 68,13,13,14,32,68,8,4,8,5,8,6,8,8,8,10,8,11,14,8,68,11
	.align 2
Lfde1_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Mono.Security.ASN1:get_Count"
	.asciz "Mono_Security_ASN1_get_Count"

	.byte 1,96
	.long Mono_Security_ASN1_get_Count
	.long Lme_2

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM47=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM47
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM48=Lfde2_end - Lfde2_start
	.long LDIFF_SYM48
Lfde2_start:

	.long 0
	.align 2
	.long Mono_Security_ASN1_get_Count

LDIFF_SYM49=Lme_2 - Mono_Security_ASN1_get_Count
	.long LDIFF_SYM49
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,2,52,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde2_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Mono.Security.ASN1:get_Tag"
	.asciz "Mono_Security_ASN1_get_Tag"

	.byte 1,103
	.long Mono_Security_ASN1_get_Tag
	.long Lme_3

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM50=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM50
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM51=Lfde3_end - Lfde3_start
	.long LDIFF_SYM51
Lfde3_start:

	.long 0
	.align 2
	.long Mono_Security_ASN1_get_Tag

LDIFF_SYM52=Lme_3 - Mono_Security_ASN1_get_Tag
	.long LDIFF_SYM52
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,76,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde3_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Mono.Security.ASN1:get_Value"
	.asciz "Mono_Security_ASN1_get_Value"

	.byte 1,117
	.long Mono_Security_ASN1_get_Value
	.long Lme_4

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM53=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM53
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM54=Lfde4_end - Lfde4_start
	.long LDIFF_SYM54
Lfde4_start:

	.long 0
	.align 2
	.long Mono_Security_ASN1_get_Value

LDIFF_SYM55=Lme_4 - Mono_Security_ASN1_get_Value
	.long LDIFF_SYM55
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,132,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde4_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Mono.Security.ASN1:Add"
	.asciz "Mono_Security_ASN1_Add_Mono_Security_ASN1"

	.byte 1,151,1
	.long Mono_Security_ASN1_Add_Mono_Security_ASN1
	.long Lme_5

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM56=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM56
	.byte 1,86,3
	.asciz "asn1"

LDIFF_SYM57=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM57
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM58=Lfde5_end - Lfde5_start
	.long LDIFF_SYM58
Lfde5_start:

	.long 0
	.align 2
	.long Mono_Security_ASN1_Add_Mono_Security_ASN1

LDIFF_SYM59=Lme_5 - Mono_Security_ASN1_Add_Mono_Security_ASN1
	.long LDIFF_SYM59
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,40,2,148,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde5_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_6:

	.byte 17
	.asciz "System_Collections_IEnumerator"

	.byte 8,7
	.asciz "System_Collections_IEnumerator"

LDIFF_SYM60=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM60
LTDIE_6_POINTER:

	.byte 13
LDIFF_SYM61=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM61
LTDIE_6_REFERENCE:

	.byte 14
LDIFF_SYM62=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM62
LTDIE_7:

	.byte 17
	.asciz "System_IDisposable"

	.byte 8,7
	.asciz "System_IDisposable"

LDIFF_SYM63=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM63
LTDIE_7_POINTER:

	.byte 13
LDIFF_SYM64=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM64
LTDIE_7_REFERENCE:

	.byte 14
LDIFF_SYM65=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM65
	.byte 2
	.asciz "Mono.Security.ASN1:GetBytes"
	.asciz "Mono_Security_ASN1_GetBytes"

	.byte 1,161,1
	.long Mono_Security_ASN1_GetBytes
	.long Lme_6

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM66=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM66
	.byte 3,123,200,0,11
	.asciz "val"

LDIFF_SYM67=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM67
	.byte 2,123,8,11
	.asciz "der"

LDIFF_SYM68=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM68
	.byte 1,86,11
	.asciz "nLengthLen"

LDIFF_SYM69=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM69
	.byte 1,85,11
	.asciz "esize"

LDIFF_SYM70=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM70
	.byte 2,123,12,11
	.asciz "al"

LDIFF_SYM71=LTDIE_4_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM71
	.byte 1,90,11
	.asciz "pos"

LDIFF_SYM72=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM72
	.byte 1,84,11
	.asciz "V_6"

LDIFF_SYM73=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM73
	.byte 2,123,16,11
	.asciz "item"

LDIFF_SYM74=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM74
	.byte 2,123,20,11
	.asciz "V_8"

LDIFF_SYM75=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM75
	.byte 2,123,24,11
	.asciz "i"

LDIFF_SYM76=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM76
	.byte 2,123,28,11
	.asciz "item"

LDIFF_SYM77=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM77
	.byte 2,123,32,11
	.asciz "nLength"

LDIFF_SYM78=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM78
	.byte 2,123,36,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM79=Lfde6_end - Lfde6_start
	.long LDIFF_SYM79
Lfde6_start:

	.long 0
	.align 2
	.long Mono_Security_ASN1_GetBytes

LDIFF_SYM80=Lme_6 - Mono_Security_ASN1_GetBytes
	.long LDIFF_SYM80
	.byte 68,14,8,135,2,72,14,32,132,8,133,7,134,6,136,5,138,4,139,3,142,1,68,14,120,68,13,11,3,68,6,10
	.byte 68,13,13,14,32,68,8,4,8,5,8,6,8,8,8,10,8,11,14,8,68,11
	.align 2
Lfde6_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Mono.Security.ASN1:Decode"
	.asciz "Mono_Security_ASN1_Decode_byte___int__int"

	.byte 1,0
	.long Mono_Security_ASN1_Decode_byte___int__int
	.long Lme_7

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM81=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM81
	.byte 1,84,3
	.asciz "asn1"

LDIFF_SYM82=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM82
	.byte 1,85,3
	.asciz "anPos"

LDIFF_SYM83=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM83
	.byte 1,86,3
	.asciz "anLength"

LDIFF_SYM84=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM84
	.byte 2,123,24,11
	.asciz "nTag"

LDIFF_SYM85=LDIE_U1 - Ldebug_info_start
	.long LDIFF_SYM85
	.byte 2,123,8,11
	.asciz "nLength"

LDIFF_SYM86=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM86
	.byte 2,123,12,11
	.asciz "aValue"

LDIFF_SYM87=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM87
	.byte 2,123,16,11
	.asciz "elm"

LDIFF_SYM88=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM88
	.byte 1,90,11
	.asciz "nConstructedPos"

LDIFF_SYM89=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM89
	.byte 2,123,20,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM90=Lfde7_end - Lfde7_start
	.long LDIFF_SYM90
Lfde7_start:

	.long 0
	.align 2
	.long Mono_Security_ASN1_Decode_byte___int__int

LDIFF_SYM91=Lme_7 - Mono_Security_ASN1_Decode_byte___int__int
	.long LDIFF_SYM91
	.byte 68,14,8,135,2,72,14,32,132,8,133,7,134,6,136,5,138,4,139,3,142,1,68,14,80,68,13,11,3,16,1,10
	.byte 68,13,13,14,32,68,8,4,8,5,8,6,8,8,8,10,8,11,14,8,68,11
	.align 2
Lfde7_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Mono.Security.ASN1:DecodeTLV"
	.asciz "Mono_Security_ASN1_DecodeTLV_byte___int__byte__int__byte___"

	.byte 1,139,2
	.long Mono_Security_ASN1_DecodeTLV_byte___int__byte__int__byte___
	.long Lme_8

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM92=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM92
	.byte 0,3
	.asciz "asn1"

LDIFF_SYM93=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM93
	.byte 1,90,3
	.asciz "pos"

LDIFF_SYM94=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM94
	.byte 1,84,3
	.asciz "tag"

LDIFF_SYM95=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM95
	.byte 2,123,20,3
	.asciz "length"

LDIFF_SYM96=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM96
	.byte 2,123,24,3
	.asciz "content"

LDIFF_SYM97=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM97
	.byte 2,123,28,11
	.asciz "V_0"

LDIFF_SYM98=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM98
	.byte 1,86,11
	.asciz "nLengthLen"

LDIFF_SYM99=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM99
	.byte 2,123,8,11
	.asciz "i"

LDIFF_SYM100=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM100
	.byte 2,123,12,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM101=Lfde8_end - Lfde8_start
	.long LDIFF_SYM101
Lfde8_start:

	.long 0
	.align 2
	.long Mono_Security_ASN1_DecodeTLV_byte___int__byte__int__byte___

LDIFF_SYM102=Lme_8 - Mono_Security_ASN1_DecodeTLV_byte___int__byte__int__byte___
	.long LDIFF_SYM102
	.byte 68,14,8,135,2,72,14,28,132,7,134,6,136,5,138,4,139,3,142,1,68,14,72,68,13,11,3,104,1,10,68,13
	.byte 13,14,28,68,8,4,8,6,8,8,8,10,8,11,14,8,68,11
	.align 2
Lfde8_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Mono.Security.ASN1:get_Item"
	.asciz "Mono_Security_ASN1_get_Item_int"

	.byte 1,157,2
	.long Mono_Security_ASN1_get_Item_int
	.long Lme_9

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM103=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM103
	.byte 1,86,3
	.asciz "index"

LDIFF_SYM104=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM104
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM105=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM105
	.byte 2,123,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM106=Lfde9_end - Lfde9_start
	.long LDIFF_SYM106
Lfde9_start:

	.long 0
	.align 2
	.long Mono_Security_ASN1_get_Item_int

LDIFF_SYM107=Lme_9 - Mono_Security_ASN1_get_Item_int
	.long LDIFF_SYM107
	.byte 68,14,8,135,2,72,14,24,134,6,136,5,138,4,139,3,142,1,68,14,48,68,13,11,2,200,10,68,13,13,14,24
	.byte 68,8,6,8,8,8,10,8,11,14,8,68,11
	.align 2
Lfde9_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_8:

	.byte 5
	.asciz "System_Text_StringBuilder"

	.byte 28,16
LDIFF_SYM108=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM108
	.byte 2,35,0,6
	.asciz "m_ChunkChars"

LDIFF_SYM109=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM109
	.byte 2,35,8,6
	.asciz "m_ChunkPrevious"

LDIFF_SYM110=LTDIE_8_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM110
	.byte 2,35,12,6
	.asciz "m_ChunkLength"

LDIFF_SYM111=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM111
	.byte 2,35,16,6
	.asciz "m_ChunkOffset"

LDIFF_SYM112=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM112
	.byte 2,35,20,6
	.asciz "m_MaxCapacity"

LDIFF_SYM113=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM113
	.byte 2,35,24,0,7
	.asciz "System_Text_StringBuilder"

LDIFF_SYM114=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM114
LTDIE_8_POINTER:

	.byte 13
LDIFF_SYM115=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM115
LTDIE_8_REFERENCE:

	.byte 14
LDIFF_SYM116=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM116
	.byte 2
	.asciz "Mono.Security.ASN1:ToString"
	.asciz "Mono_Security_ASN1_ToString"

	.byte 1,186,2
	.long Mono_Security_ASN1_ToString
	.long Lme_a

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM117=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM117
	.byte 1,90,11
	.asciz "hexLine"

LDIFF_SYM118=LTDIE_8_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM118
	.byte 1,86,11
	.asciz "i"

LDIFF_SYM119=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM119
	.byte 1,85,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM120=Lfde10_end - Lfde10_start
	.long LDIFF_SYM120
Lfde10_start:

	.long 0
	.align 2
	.long Mono_Security_ASN1_ToString

LDIFF_SYM121=Lme_a - Mono_Security_ASN1_ToString
	.long LDIFF_SYM121
	.byte 68,14,8,135,2,72,14,24,133,6,134,5,136,4,138,3,142,1,68,14,104,3,32,2,10,68,14,24,68,8,5,8
	.byte 6,8,8,8,10,14,8,68,11
	.align 2
Lfde10_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_unknown)_byte[]:Get"
	.asciz "wrapper_unknown_byte___Get_int"

	.byte 0,0
	.long wrapper_unknown_byte___Get_int
	.long Lme_c

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM122=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM122
	.byte 2,125,0,3
	.asciz "param0"

LDIFF_SYM123=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM123
	.byte 2,125,4,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM124=Lfde11_end - Lfde11_start
	.long LDIFF_SYM124
Lfde11_start:

	.long 0
	.align 2
	.long wrapper_unknown_byte___Get_int

LDIFF_SYM125=Lme_c - wrapper_unknown_byte___Get_int
	.long LDIFF_SYM125
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,2,40,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde11_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_runtime-invoke)_<Module>:runtime_invoke_byte__this___int"
	.asciz "wrapper_runtime_invoke__Module_runtime_invoke_byte__this___int_object_intptr_intptr_intptr"

	.byte 0,0
	.long wrapper_runtime_invoke__Module_runtime_invoke_byte__this___int_object_intptr_intptr_intptr
	.long Lme_d

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM126=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM126
	.byte 2,123,24,3
	.asciz "params"

LDIFF_SYM127=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM127
	.byte 2,123,28,3
	.asciz "exc"

LDIFF_SYM128=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM128
	.byte 2,123,32,3
	.asciz "method"

LDIFF_SYM129=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM129
	.byte 2,123,36,11
	.asciz "V_0"

LDIFF_SYM130=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM130
	.byte 2,123,0,11
	.asciz "V_1"

LDIFF_SYM131=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM131
	.byte 2,123,4,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM132=Lfde12_end - Lfde12_start
	.long LDIFF_SYM132
Lfde12_start:

	.long 0
	.align 2
	.long wrapper_runtime_invoke__Module_runtime_invoke_byte__this___int_object_intptr_intptr_intptr

LDIFF_SYM133=Lme_d - wrapper_runtime_invoke__Module_runtime_invoke_byte__this___int_object_intptr_intptr_intptr
	.long LDIFF_SYM133
	.byte 68,14,8,135,2,72,14,20,132,5,136,4,139,3,142,1,68,14,72,68,13,11,3,48,1,10,68,13,13,14,20,68
	.byte 8,4,8,8,8,11,14,8,68,11
	.align 2
Lfde12_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_unknown)_byte[]:Set"
	.asciz "wrapper_unknown_byte___Set_int_byte"

	.byte 0,0
	.long wrapper_unknown_byte___Set_int_byte
	.long Lme_e

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM134=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM134
	.byte 2,125,0,3
	.asciz "param0"

LDIFF_SYM135=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM135
	.byte 2,125,4,3
	.asciz "param1"

LDIFF_SYM136=LDIE_U1 - Ldebug_info_start
	.long LDIFF_SYM136
	.byte 2,125,8,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM137=Lfde13_end - Lfde13_start
	.long LDIFF_SYM137
Lfde13_start:

	.long 0
	.align 2
	.long wrapper_unknown_byte___Set_int_byte

LDIFF_SYM138=Lme_e - wrapper_unknown_byte___Set_int_byte
	.long LDIFF_SYM138
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,2,48,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde13_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_runtime-invoke)_<Module>:runtime_invoke_void__this___int_byte"
	.asciz "wrapper_runtime_invoke__Module_runtime_invoke_void__this___int_byte_object_intptr_intptr_intptr"

	.byte 0,0
	.long wrapper_runtime_invoke__Module_runtime_invoke_void__this___int_byte_object_intptr_intptr_intptr
	.long Lme_f

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM139=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM139
	.byte 2,123,24,3
	.asciz "params"

LDIFF_SYM140=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM140
	.byte 1,86,3
	.asciz "exc"

LDIFF_SYM141=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM141
	.byte 2,123,28,3
	.asciz "method"

LDIFF_SYM142=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM142
	.byte 2,123,32,11
	.asciz "V_0"

LDIFF_SYM143=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM143
	.byte 2,123,0,11
	.asciz "V_1"

LDIFF_SYM144=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM144
	.byte 2,123,4,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM145=Lfde14_end - Lfde14_start
	.long LDIFF_SYM145
Lfde14_start:

	.long 0
	.align 2
	.long wrapper_runtime_invoke__Module_runtime_invoke_void__this___int_byte_object_intptr_intptr_intptr

LDIFF_SYM146=Lme_f - wrapper_runtime_invoke__Module_runtime_invoke_void__this___int_byte_object_intptr_intptr_intptr
	.long LDIFF_SYM146
	.byte 68,14,8,135,2,72,14,24,132,6,134,5,136,4,139,3,142,1,68,14,72,68,13,11,2,244,10,68,13,13,14,24
	.byte 68,8,4,8,6,8,8,8,11,14,8,68,11
	.align 2
Lfde14_end:

.section __DWARF, __debug_info,regular,debug

	.byte 0
Ldebug_info_end:
.text
	.align 3
mem_end:
