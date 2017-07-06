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
	.byte 8,1
	.asciz "Mono AOT Compiler 5.0.0 (tarball Fri May  5 18:00:38 EDT 2017)"
	.asciz "PorpoiseUnitTest.exe"
	.asciz ""

	.byte 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
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

	.byte 4,8,5
	.asciz "intptr"
LDIE_U:

	.byte 4,8,7
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

	.byte 4,8,1
	.asciz "string"
LDIE_OBJECT:

	.byte 4,8,1
	.asciz "object"
LDIE_SZARRAY:

	.byte 4,8,1
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

	.byte 1,120,30
	.align 3
Lcie0_end:
.text
	.align 3
jit_code_start:

	.byte 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
.text
	.align 4
	.no_dead_strip Fixtures_Tests_Pass
Fixtures_Tests_Pass:
.file 1 "/Users/luis/Documents/BACKUP/porpoise-mobile-app/PorpoiseMobileApp/PorpoiseUnitTest/Fixtures/Tests.cs"
.loc 1 14 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_PorpoiseUnitTest_got@PAGE+0
add x16, x16, mono_aot_PorpoiseUnitTest_got@PAGEOFF
ldr x16, [x16, #208]
.word 0xf9000fb0
.word 0xf9400a11
.word 0xf90013b1
.word 0xf9400fb1
.word 0xf9403231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf9405231
.word 0xb4000051
.word 0xd63f0220
.loc 1 15 0
.word 0xf9400fb1
.word 0xf9406231
.word 0xb4000051
.word 0xd63f0220
.word 0xd2800020
.word 0xd2800020
bl _p_1
.word 0xf9400fb1
.word 0xf9407e31
.word 0xb4000051
.word 0xd63f0220
.loc 1 16 0
.word 0xf9400fb1
.word 0xf9408e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf9409e31
.word 0xb4000051
.word 0xd63f0220
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_0:
.text
	.align 4
	.no_dead_strip Fixtures_Tests_Fail
Fixtures_Tests_Fail:
.loc 1 20 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_PorpoiseUnitTest_got@PAGE+0
add x16, x16, mono_aot_PorpoiseUnitTest_got@PAGEOFF
ldr x16, [x16, #216]
.word 0xf9000fb0
.word 0xf9400a11
.word 0xf90013b1
.word 0xf9400fb1
.word 0xf9403231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf9405231
.word 0xb4000051
.word 0xd63f0220
.loc 1 21 0
.word 0xf9400fb1
.word 0xf9406231
.word 0xb4000051
.word 0xd63f0220
.word 0xd2800020
.word 0xd2800020
bl _p_2
.word 0xf9400fb1
.word 0xf9407e31
.word 0xb4000051
.word 0xd63f0220
.loc 1 22 0
.word 0xf9400fb1
.word 0xf9408e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf9409e31
.word 0xb4000051
.word 0xd63f0220
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_1:
.text
	.align 4
	.no_dead_strip Fixtures_Tests_Ignore
Fixtures_Tests_Ignore:
.loc 1 27 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_PorpoiseUnitTest_got@PAGE+0
add x16, x16, mono_aot_PorpoiseUnitTest_got@PAGEOFF
ldr x16, [x16, #224]
.word 0xf9000fb0
.word 0xf9400a11
.word 0xf90013b1
.word 0xf9400fb1
.word 0xf9403231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf9405231
.word 0xb4000051
.word 0xd63f0220
.loc 1 28 0
.word 0xf9400fb1
.word 0xf9406231
.word 0xb4000051
.word 0xd63f0220
.word 0xd2800000
.word 0xd2800000
bl _p_1
.word 0xf9400fb1
.word 0xf9407e31
.word 0xb4000051
.word 0xd63f0220
.loc 1 29 0
.word 0xf9400fb1
.word 0xf9408e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf9409e31
.word 0xb4000051
.word 0xd63f0220
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_2:
.text
	.align 4
	.no_dead_strip Fixtures_Tests__ctor
Fixtures_Tests__ctor:
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_PorpoiseUnitTest_got@PAGE+0
add x16, x16, mono_aot_PorpoiseUnitTest_got@PAGEOFF
ldr x16, [x16, #232]
.word 0xf9000fb0
.word 0xf9400a11
.word 0xf90013b1
.word 0xf9400fb1
.word 0xf9403231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400ba0
.word 0xf9400fb1
.word 0xf9404631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf9405631
.word 0xb4000051
.word 0xd63f0220
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_3:
.text
	.align 4
	.no_dead_strip PorpoiseUnitTest_Application_Main_string__
PorpoiseUnitTest_Application_Main_string__:
.file 2 "/Users/luis/Documents/BACKUP/porpoise-mobile-app/PorpoiseMobileApp/PorpoiseUnitTest/Main.cs"
.loc 2 14 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_PorpoiseUnitTest_got@PAGE+0
add x16, x16, mono_aot_PorpoiseUnitTest_got@PAGEOFF
ldr x16, [x16, #240]
.word 0xf9000fb0
.word 0xf9400a11
.word 0xf90013b1
.word 0xf9400fb1
.word 0xf9403231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf9405231
.word 0xb4000051
.word 0xd63f0220
.loc 2 17 0
.word 0xf9400fb1
.word 0xf9406231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400ba0
.word 0xd2800001

adrp x16, mono_aot_PorpoiseUnitTest_got@PAGE+0
add x16, x16, mono_aot_PorpoiseUnitTest_got@PAGEOFF
ldr x2, [x16, #248]
.word 0xd2800001
bl _p_3
.word 0xf9400fb1
.word 0xf9408e31
.word 0xb4000051
.word 0xd63f0220
.loc 2 18 0
.word 0xf9400fb1
.word 0xf9409e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf940ae31
.word 0xb4000051
.word 0xd63f0220
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_4:
.text
	.align 4
	.no_dead_strip PorpoiseUnitTest_Application__ctor
PorpoiseUnitTest_Application__ctor:
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_PorpoiseUnitTest_got@PAGE+0
add x16, x16, mono_aot_PorpoiseUnitTest_got@PAGEOFF
ldr x16, [x16, #256]
.word 0xf9000fb0
.word 0xf9400a11
.word 0xf90013b1
.word 0xf9400fb1
.word 0xf9403231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400ba0
.word 0xf9400fb1
.word 0xf9404631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf9405631
.word 0xb4000051
.word 0xd63f0220
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_5:
.text
	.align 4
	.no_dead_strip PorpoiseUnitTest_UnitTestAppDelegate_FinishedLaunching_UIKit_UIApplication_Foundation_NSDictionary
PorpoiseUnitTest_UnitTestAppDelegate_FinishedLaunching_UIKit_UIApplication_Foundation_NSDictionary:
.file 3 "/Users/luis/Documents/BACKUP/porpoise-mobile-app/PorpoiseMobileApp/PorpoiseUnitTest/UnitTestAppDelegate.cs"
.loc 3 29 0 prologue_end
.word 0xa9b37bfd
.word 0x910003fd
.word 0xa9016bb9
.word 0xaa0003fa
.word 0xf90013a1
.word 0xf90017a2

adrp x16, mono_aot_PorpoiseUnitTest_got@PAGE+0
add x16, x16, mono_aot_PorpoiseUnitTest_got@PAGEOFF
ldr x16, [x16, #264]
.word 0xf9001bb0
.word 0xf9400a11
.word 0xf9001fb1
.word 0xd2800019
.word 0xf9401bb1
.word 0xf9404231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401fb1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401bb1
.word 0xf9406231
.word 0xb4000051
.word 0xd63f0220
.loc 3 31 0
.word 0xf9401bb1
.word 0xf9407231
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
bl _p_4
.word 0xf90063a0
.word 0xf9401bb1
.word 0xf9408e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94063a1
.word 0x910123a0
.word 0xf90037a0
.word 0xaa0103e0
.word 0xf9400021
.word 0xf940e030
.word 0xd63f0200
.word 0xf94037be
.word 0xfd0003c0
.word 0xfd0007c1
.word 0xfd000bc2
.word 0xfd000fc3
.word 0xf9401bb1
.word 0xf940ce31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_PorpoiseUnitTest_got@PAGE+0
add x16, x16, mono_aot_PorpoiseUnitTest_got@PAGEOFF
ldr x0, [x16, #272]
bl _p_5
.word 0xf9005fa0
.word 0x910123a1
.word 0xfd4027a0
.word 0xfd402ba1
.word 0xfd402fa2
.word 0xfd4033a3
bl _p_6
.word 0xf9401bb1
.word 0xf9410a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9405fa0
.word 0xf9005ba0
.word 0xf9001740
.word 0x9100a340
bl _p_7
.word 0xf9405ba0
.loc 3 32 0
.word 0xf9401bb1
.word 0xf9413231
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
.word 0xaa1a03e0
.word 0xf9401740
.word 0xf90057a0

adrp x16, mono_aot_PorpoiseUnitTest_got@PAGE+0
add x16, x16, mono_aot_PorpoiseUnitTest_got@PAGEOFF
ldr x0, [x16, #280]
.word 0xd2801201
.word 0xd2801201
bl _p_8
.word 0xf94057a1
.word 0xf90053a0
bl _p_9
.word 0xf9401bb1
.word 0xf9417631
.word 0xb4000051
.word 0xd63f0220
.word 0xf94053a0
.word 0xf9004fa0
.word 0xf9001b40
.word 0x9100c340
bl _p_7
.word 0xf9404fa0
.loc 3 35 0
.word 0xf9401bb1
.word 0xf9419e31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
.word 0xf9401b40
.word 0xf9004ba0
bl _p_10
.word 0xf90047a0
.word 0xf9401bb1
.word 0xf941c231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94047a1
.word 0xf9404ba2
.word 0xaa0203e0
.word 0xf940005e
bl _p_11
.word 0xf9401bb1
.word 0xf941e631
.word 0xb4000051
.word 0xd63f0220
.loc 3 37 0
.word 0xf9401bb1
.word 0xf941f631
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
.word 0xf9401740
.word 0xf9003fa0
.word 0xaa1a03e0
.word 0xf9401b41
.word 0xaa0103e0
.word 0xf940003e
bl _p_12
.word 0xf90043a0
.word 0xf9401bb1
.word 0xf9422a31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_PorpoiseUnitTest_got@PAGE+0
add x16, x16, mono_aot_PorpoiseUnitTest_got@PAGEOFF
ldr x0, [x16, #288]
bl _p_5
.word 0xf94043a1
.word 0xf9003ba0
bl _p_13
.word 0xf9401bb1
.word 0xf9425631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9403ba1
.word 0xf9403fa2
.word 0xaa0203e0
.word 0xf9400042
.word 0xf941d050
.word 0xd63f0200
.word 0xf9401bb1
.word 0xf9427e31
.word 0xb4000051
.word 0xd63f0220
.loc 3 40 0
.word 0xf9401bb1
.word 0xf9428e31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
.word 0xf9401741
.word 0xaa0103e0
.word 0xf9400021
.word 0xf941d830
.word 0xd63f0200
.word 0xf9401bb1
.word 0xf942b631
.word 0xb4000051
.word 0xd63f0220
.loc 3 42 0
.word 0xf9401bb1
.word 0xf942c631
.word 0xb4000051
.word 0xd63f0220
.word 0xd2800039
.loc 3 43 0
.word 0xf9401bb1
.word 0xf942da31
.word 0xb4000051
.word 0xd63f0220
.word 0xd2800020
.word 0xd2800020
.word 0xf9401bb1
.word 0xf942f231
.word 0xb4000051
.word 0xd63f0220
.word 0xa9416bb9
.word 0x910003bf
.word 0xa8cd7bfd
.word 0xd65f03c0

Lme_6:
.text
	.align 4
	.no_dead_strip PorpoiseUnitTest_UnitTestAppDelegate__ctor
PorpoiseUnitTest_UnitTestAppDelegate__ctor:
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_PorpoiseUnitTest_got@PAGE+0
add x16, x16, mono_aot_PorpoiseUnitTest_got@PAGEOFF
ldr x16, [x16, #296]
.word 0xf9000fb0
.word 0xf9400a11
.word 0xf90013b1
.word 0xf9400fb1
.word 0xf9403231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400ba0
bl _p_14
.word 0xf9400fb1
.word 0xf9404a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf9405a31
.word 0xb4000051
.word 0xd63f0220
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_7:
.text
	.align 3
jit_code_end:

	.byte 0,0,0,0
.text
	.align 3
method_addresses:
	.no_dead_strip method_addresses
bl Fixtures_Tests_Pass
bl Fixtures_Tests_Fail
bl Fixtures_Tests_Ignore
bl Fixtures_Tests__ctor
bl PorpoiseUnitTest_Application_Main_string__
bl PorpoiseUnitTest_Application__ctor
bl PorpoiseUnitTest_UnitTestAppDelegate_FinishedLaunching_UIKit_UIApplication_Foundation_NSDictionary
bl PorpoiseUnitTest_UnitTestAppDelegate__ctor
bl method_addresses
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

	.byte 13,12,31,0,68,14,48,157,6,158,5,68,13,29,19,12,31,0,68,14,208,1,157,26,158,25,68,13,29,68,153,24
	.byte 154,23

.text
	.align 4
plt:
mono_aot_PorpoiseUnitTest_plt:
	.no_dead_strip plt_NUnit_Framework_Assert_True_bool
plt_NUnit_Framework_Assert_True_bool:
_p_1:
adrp x16, mono_aot_PorpoiseUnitTest_got@PAGE+0
add x16, x16, mono_aot_PorpoiseUnitTest_got@PAGEOFF
ldr x16, [x16, #312]
br x16
.word 314
	.no_dead_strip plt_NUnit_Framework_Assert_False_bool
plt_NUnit_Framework_Assert_False_bool:
_p_2:
adrp x16, mono_aot_PorpoiseUnitTest_got@PAGE+0
add x16, x16, mono_aot_PorpoiseUnitTest_got@PAGEOFF
ldr x16, [x16, #320]
br x16
.word 319
	.no_dead_strip plt_UIKit_UIApplication_Main_string___string_string
plt_UIKit_UIApplication_Main_string___string_string:
_p_3:
adrp x16, mono_aot_PorpoiseUnitTest_got@PAGE+0
add x16, x16, mono_aot_PorpoiseUnitTest_got@PAGEOFF
ldr x16, [x16, #328]
br x16
.word 324
	.no_dead_strip plt_UIKit_UIScreen_get_MainScreen
plt_UIKit_UIScreen_get_MainScreen:
_p_4:
adrp x16, mono_aot_PorpoiseUnitTest_got@PAGE+0
add x16, x16, mono_aot_PorpoiseUnitTest_got@PAGEOFF
ldr x16, [x16, #336]
br x16
.word 329
	.no_dead_strip plt__jit_icall_ves_icall_object_new_specific
plt__jit_icall_ves_icall_object_new_specific:
_p_5:
adrp x16, mono_aot_PorpoiseUnitTest_got@PAGE+0
add x16, x16, mono_aot_PorpoiseUnitTest_got@PAGEOFF
ldr x16, [x16, #344]
br x16
.word 334
	.no_dead_strip plt_UIKit_UIWindow__ctor_CoreGraphics_CGRect
plt_UIKit_UIWindow__ctor_CoreGraphics_CGRect:
_p_6:
adrp x16, mono_aot_PorpoiseUnitTest_got@PAGE+0
add x16, x16, mono_aot_PorpoiseUnitTest_got@PAGEOFF
ldr x16, [x16, #352]
br x16
.word 366
	.no_dead_strip plt_wrapper_write_barrier_object_wbarrier_conc_intptr
plt_wrapper_write_barrier_object_wbarrier_conc_intptr:
_p_7:
adrp x16, mono_aot_PorpoiseUnitTest_got@PAGE+0
add x16, x16, mono_aot_PorpoiseUnitTest_got@PAGEOFF
ldr x16, [x16, #360]
br x16
.word 371
	.no_dead_strip plt_wrapper_alloc_object_AllocSmall_intptr_intptr
plt_wrapper_alloc_object_AllocSmall_intptr_intptr:
_p_8:
adrp x16, mono_aot_PorpoiseUnitTest_got@PAGE+0
add x16, x16, mono_aot_PorpoiseUnitTest_got@PAGEOFF
ldr x16, [x16, #368]
br x16
.word 378
	.no_dead_strip plt_MonoTouch_NUnit_UI_TouchRunner__ctor_UIKit_UIWindow
plt_MonoTouch_NUnit_UI_TouchRunner__ctor_UIKit_UIWindow:
_p_9:
adrp x16, mono_aot_PorpoiseUnitTest_got@PAGE+0
add x16, x16, mono_aot_PorpoiseUnitTest_got@PAGEOFF
ldr x16, [x16, #376]
br x16
.word 386
	.no_dead_strip plt_System_Reflection_Assembly_GetExecutingAssembly
plt_System_Reflection_Assembly_GetExecutingAssembly:
_p_10:
adrp x16, mono_aot_PorpoiseUnitTest_got@PAGE+0
add x16, x16, mono_aot_PorpoiseUnitTest_got@PAGEOFF
ldr x16, [x16, #384]
br x16
.word 391
	.no_dead_strip plt_MonoTouch_NUnit_UI_BaseTouchRunner_Add_System_Reflection_Assembly
plt_MonoTouch_NUnit_UI_BaseTouchRunner_Add_System_Reflection_Assembly:
_p_11:
adrp x16, mono_aot_PorpoiseUnitTest_got@PAGE+0
add x16, x16, mono_aot_PorpoiseUnitTest_got@PAGEOFF
ldr x16, [x16, #392]
br x16
.word 396
	.no_dead_strip plt_MonoTouch_NUnit_UI_TouchRunner_GetViewController
plt_MonoTouch_NUnit_UI_TouchRunner_GetViewController:
_p_12:
adrp x16, mono_aot_PorpoiseUnitTest_got@PAGE+0
add x16, x16, mono_aot_PorpoiseUnitTest_got@PAGEOFF
ldr x16, [x16, #400]
br x16
.word 401
	.no_dead_strip plt_UIKit_UINavigationController__ctor_UIKit_UIViewController
plt_UIKit_UINavigationController__ctor_UIKit_UIViewController:
_p_13:
adrp x16, mono_aot_PorpoiseUnitTest_got@PAGE+0
add x16, x16, mono_aot_PorpoiseUnitTest_got@PAGEOFF
ldr x16, [x16, #408]
br x16
.word 406
	.no_dead_strip plt_UIKit_UIApplicationDelegate__ctor
plt_UIKit_UIApplicationDelegate__ctor:
_p_14:
adrp x16, mono_aot_PorpoiseUnitTest_got@PAGE+0
add x16, x16, mono_aot_PorpoiseUnitTest_got@PAGEOFF
ldr x16, [x16, #416]
br x16
.word 411
plt_end:
.section __DATA, __bss
	.align 3
.lcomm mono_aot_PorpoiseUnitTest_got, 424
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
	.align 3
	.quad Lglobals_hash

	.long 0,0
.section __TEXT, __const
	.align 2
runtime_version:
	.asciz ""
.section __TEXT, __const
	.align 2
assembly_guid:
	.asciz "97578E33-E888-445D-BFFD-501E61800037"
.section __TEXT, __const
	.align 2
assembly_name:
	.asciz "PorpoiseUnitTest"
.data
	.align 3
_mono_aot_file_info:

	.long 139,0
	.align 3
	.quad mono_aot_PorpoiseUnitTest_got
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad jit_code_start
	.align 3
	.quad jit_code_end
	.align 3
	.quad method_addresses
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad mem_end
	.align 3
	.quad assembly_guid
	.align 3
	.quad runtime_version
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad globals
	.align 3
	.quad assembly_name
	.align 3
	.quad plt
	.align 3
	.quad plt_end
	.align 3
	.quad unwind_info
	.align 3
	.quad unbox_trampolines
	.align 3
	.quad unbox_trampolines_end
	.align 3
	.quad unbox_trampoline_addresses

	.long 38,424,15,9,70,391195135,0,1312
	.long 128,8,8,10,0,26,2040,720
	.long 360,184,0,296,336,232,0,176
	.long 32,0,0,0,0,0,0,0
	.long 0,0,0,0,0,0,0,0
	.long 0
	.byte 246,243,28,86,234,165,44,12,218,197,233,44,106,78,45,20
	.globl _mono_aot_module_PorpoiseUnitTest_info
	.align 3
_mono_aot_module_PorpoiseUnitTest_info:
	.align 3
	.quad _mono_aot_file_info
.section __DWARF, __debug_info,regular,debug
LTDIE_1:

	.byte 17
	.asciz "System_Object"

	.byte 16,7
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
LTDIE_0:

	.byte 5
	.asciz "Fixtures_Tests"

	.byte 16,16
LDIFF_SYM6=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM6
	.byte 2,35,0,0,7
	.asciz "Fixtures_Tests"

LDIFF_SYM7=LTDIE_0 - Ldebug_info_start
	.long LDIFF_SYM7
LTDIE_0_POINTER:

	.byte 13
LDIFF_SYM8=LTDIE_0 - Ldebug_info_start
	.long LDIFF_SYM8
LTDIE_0_REFERENCE:

	.byte 14
LDIFF_SYM9=LTDIE_0 - Ldebug_info_start
	.long LDIFF_SYM9
	.byte 2
	.asciz "Fixtures.Tests:Pass"
	.asciz "Fixtures_Tests_Pass"

	.byte 1,14
	.quad Fixtures_Tests_Pass
	.quad Lme_0

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM10=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM10
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM11=Lfde0_end - Lfde0_start
	.long LDIFF_SYM11
Lfde0_start:

	.long 0
	.align 3
	.quad Fixtures_Tests_Pass

LDIFF_SYM12=Lme_0 - Fixtures_Tests_Pass
	.long LDIFF_SYM12
	.long 0
	.byte 12,31,0,68,14,48,157,6,158,5,68,13,29
	.align 3
Lfde0_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Fixtures.Tests:Fail"
	.asciz "Fixtures_Tests_Fail"

	.byte 1,20
	.quad Fixtures_Tests_Fail
	.quad Lme_1

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM13=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM13
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM14=Lfde1_end - Lfde1_start
	.long LDIFF_SYM14
Lfde1_start:

	.long 0
	.align 3
	.quad Fixtures_Tests_Fail

LDIFF_SYM15=Lme_1 - Fixtures_Tests_Fail
	.long LDIFF_SYM15
	.long 0
	.byte 12,31,0,68,14,48,157,6,158,5,68,13,29
	.align 3
Lfde1_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Fixtures.Tests:Ignore"
	.asciz "Fixtures_Tests_Ignore"

	.byte 1,27
	.quad Fixtures_Tests_Ignore
	.quad Lme_2

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM16=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM16
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM17=Lfde2_end - Lfde2_start
	.long LDIFF_SYM17
Lfde2_start:

	.long 0
	.align 3
	.quad Fixtures_Tests_Ignore

LDIFF_SYM18=Lme_2 - Fixtures_Tests_Ignore
	.long LDIFF_SYM18
	.long 0
	.byte 12,31,0,68,14,48,157,6,158,5,68,13,29
	.align 3
Lfde2_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Fixtures.Tests:.ctor"
	.asciz "Fixtures_Tests__ctor"

	.byte 0,0
	.quad Fixtures_Tests__ctor
	.quad Lme_3

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM19=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM19
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM20=Lfde3_end - Lfde3_start
	.long LDIFF_SYM20
Lfde3_start:

	.long 0
	.align 3
	.quad Fixtures_Tests__ctor

LDIFF_SYM21=Lme_3 - Fixtures_Tests__ctor
	.long LDIFF_SYM21
	.long 0
	.byte 12,31,0,68,14,48,157,6,158,5,68,13,29
	.align 3
Lfde3_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PorpoiseUnitTest.Application:Main"
	.asciz "PorpoiseUnitTest_Application_Main_string__"

	.byte 2,14
	.quad PorpoiseUnitTest_Application_Main_string__
	.quad Lme_4

	.byte 2,118,16,3
	.asciz "args"

LDIFF_SYM22=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM22
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM23=Lfde4_end - Lfde4_start
	.long LDIFF_SYM23
Lfde4_start:

	.long 0
	.align 3
	.quad PorpoiseUnitTest_Application_Main_string__

LDIFF_SYM24=Lme_4 - PorpoiseUnitTest_Application_Main_string__
	.long LDIFF_SYM24
	.long 0
	.byte 12,31,0,68,14,48,157,6,158,5,68,13,29
	.align 3
Lfde4_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_2:

	.byte 5
	.asciz "PorpoiseUnitTest_Application"

	.byte 16,16
LDIFF_SYM25=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM25
	.byte 2,35,0,0,7
	.asciz "PorpoiseUnitTest_Application"

LDIFF_SYM26=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM26
LTDIE_2_POINTER:

	.byte 13
LDIFF_SYM27=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM27
LTDIE_2_REFERENCE:

	.byte 14
LDIFF_SYM28=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM28
	.byte 2
	.asciz "PorpoiseUnitTest.Application:.ctor"
	.asciz "PorpoiseUnitTest_Application__ctor"

	.byte 0,0
	.quad PorpoiseUnitTest_Application__ctor
	.quad Lme_5

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM29=LTDIE_2_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM29
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM30=Lfde5_end - Lfde5_start
	.long LDIFF_SYM30
Lfde5_start:

	.long 0
	.align 3
	.quad PorpoiseUnitTest_Application__ctor

LDIFF_SYM31=Lme_5 - PorpoiseUnitTest_Application__ctor
	.long LDIFF_SYM31
	.long 0
	.byte 12,31,0,68,14,48,157,6,158,5,68,13,29
	.align 3
Lfde5_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_6:

	.byte 8
	.asciz "_Flags"

	.byte 1
LDIFF_SYM32=LDIE_U1 - Ldebug_info_start
	.long LDIFF_SYM32
	.byte 9
	.asciz "Disposed"

	.byte 1,9
	.asciz "NativeRef"

	.byte 2,9
	.asciz "IsDirectBinding"

	.byte 4,9
	.asciz "RegisteredToggleRef"

	.byte 8,9
	.asciz "InFinalizerQueue"

	.byte 16,9
	.asciz "HasManagedRef"

	.byte 32,0,7
	.asciz "_Flags"

LDIFF_SYM33=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM33
LTDIE_6_POINTER:

	.byte 13
LDIFF_SYM34=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM34
LTDIE_6_REFERENCE:

	.byte 14
LDIFF_SYM35=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM35
LTDIE_5:

	.byte 5
	.asciz "Foundation_NSObject"

	.byte 40,16
LDIFF_SYM36=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM36
	.byte 2,35,0,6
	.asciz "handle"

LDIFF_SYM37=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM37
	.byte 2,35,16,6
	.asciz "class_handle"

LDIFF_SYM38=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM38
	.byte 2,35,24,6
	.asciz "flags"

LDIFF_SYM39=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM39
	.byte 2,35,32,0,7
	.asciz "Foundation_NSObject"

LDIFF_SYM40=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM40
LTDIE_5_POINTER:

	.byte 13
LDIFF_SYM41=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM41
LTDIE_5_REFERENCE:

	.byte 14
LDIFF_SYM42=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM42
LTDIE_4:

	.byte 5
	.asciz "UIKit_UIApplicationDelegate"

	.byte 40,16
LDIFF_SYM43=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM43
	.byte 2,35,0,0,7
	.asciz "UIKit_UIApplicationDelegate"

LDIFF_SYM44=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM44
LTDIE_4_POINTER:

	.byte 13
LDIFF_SYM45=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM45
LTDIE_4_REFERENCE:

	.byte 14
LDIFF_SYM46=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM46
LTDIE_9:

	.byte 5
	.asciz "UIKit_UIResponder"

	.byte 40,16
LDIFF_SYM47=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM47
	.byte 2,35,0,0,7
	.asciz "UIKit_UIResponder"

LDIFF_SYM48=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM48
LTDIE_9_POINTER:

	.byte 13
LDIFF_SYM49=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM49
LTDIE_9_REFERENCE:

	.byte 14
LDIFF_SYM50=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM50
LTDIE_8:

	.byte 5
	.asciz "UIKit_UIView"

	.byte 48,16
LDIFF_SYM51=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM51
	.byte 2,35,0,6
	.asciz "__mt_PreferredFocusedView_var"

LDIFF_SYM52=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM52
	.byte 2,35,40,0,7
	.asciz "UIKit_UIView"

LDIFF_SYM53=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM53
LTDIE_8_POINTER:

	.byte 13
LDIFF_SYM54=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM54
LTDIE_8_REFERENCE:

	.byte 14
LDIFF_SYM55=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM55
LTDIE_7:

	.byte 5
	.asciz "UIKit_UIWindow"

	.byte 48,16
LDIFF_SYM56=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM56
	.byte 2,35,0,0,7
	.asciz "UIKit_UIWindow"

LDIFF_SYM57=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM57
LTDIE_7_POINTER:

	.byte 13
LDIFF_SYM58=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM58
LTDIE_7_REFERENCE:

	.byte 14
LDIFF_SYM59=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM59
LTDIE_15:

	.byte 5
	.asciz "System_ValueType"

	.byte 16,16
LDIFF_SYM60=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM60
	.byte 2,35,0,0,7
	.asciz "System_ValueType"

LDIFF_SYM61=LTDIE_15 - Ldebug_info_start
	.long LDIFF_SYM61
LTDIE_15_POINTER:

	.byte 13
LDIFF_SYM62=LTDIE_15 - Ldebug_info_start
	.long LDIFF_SYM62
LTDIE_15_REFERENCE:

	.byte 14
LDIFF_SYM63=LTDIE_15 - Ldebug_info_start
	.long LDIFF_SYM63
LTDIE_14:

	.byte 5
	.asciz "System_Int32"

	.byte 20,16
LDIFF_SYM64=LTDIE_15 - Ldebug_info_start
	.long LDIFF_SYM64
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM65=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM65
	.byte 2,35,16,0,7
	.asciz "System_Int32"

LDIFF_SYM66=LTDIE_14 - Ldebug_info_start
	.long LDIFF_SYM66
LTDIE_14_POINTER:

	.byte 13
LDIFF_SYM67=LTDIE_14 - Ldebug_info_start
	.long LDIFF_SYM67
LTDIE_14_REFERENCE:

	.byte 14
LDIFF_SYM68=LTDIE_14 - Ldebug_info_start
	.long LDIFF_SYM68
LTDIE_16:

	.byte 8
	.asciz "NUnit_Framework_Api_RunState"

	.byte 4
LDIFF_SYM69=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM69
	.byte 9
	.asciz "NotRunnable"

	.byte 0,9
	.asciz "Runnable"

	.byte 1,9
	.asciz "Explicit"

	.byte 2,9
	.asciz "Skipped"

	.byte 3,9
	.asciz "Ignored"

	.byte 4,0,7
	.asciz "NUnit_Framework_Api_RunState"

LDIFF_SYM70=LTDIE_16 - Ldebug_info_start
	.long LDIFF_SYM70
LTDIE_16_POINTER:

	.byte 13
LDIFF_SYM71=LTDIE_16 - Ldebug_info_start
	.long LDIFF_SYM71
LTDIE_16_REFERENCE:

	.byte 14
LDIFF_SYM72=LTDIE_16 - Ldebug_info_start
	.long LDIFF_SYM72
LTDIE_17:

	.byte 17
	.asciz "NUnit_Framework_Api_ITest"

	.byte 16,7
	.asciz "NUnit_Framework_Api_ITest"

LDIFF_SYM73=LTDIE_17 - Ldebug_info_start
	.long LDIFF_SYM73
LTDIE_17_POINTER:

	.byte 13
LDIFF_SYM74=LTDIE_17 - Ldebug_info_start
	.long LDIFF_SYM74
LTDIE_17_REFERENCE:

	.byte 14
LDIFF_SYM75=LTDIE_17 - Ldebug_info_start
	.long LDIFF_SYM75
LTDIE_20:

	.byte 17
	.asciz "System_Collections_Generic_IEqualityComparer`1"

	.byte 16,7
	.asciz "System_Collections_Generic_IEqualityComparer`1"

LDIFF_SYM76=LTDIE_20 - Ldebug_info_start
	.long LDIFF_SYM76
LTDIE_20_POINTER:

	.byte 13
LDIFF_SYM77=LTDIE_20 - Ldebug_info_start
	.long LDIFF_SYM77
LTDIE_20_REFERENCE:

	.byte 14
LDIFF_SYM78=LTDIE_20 - Ldebug_info_start
	.long LDIFF_SYM78
LTDIE_21:

	.byte 5
	.asciz "_KeyCollection"

	.byte 24,16
LDIFF_SYM79=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM79
	.byte 2,35,0,6
	.asciz "dictionary"

LDIFF_SYM80=LTDIE_19_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM80
	.byte 2,35,16,0,7
	.asciz "_KeyCollection"

LDIFF_SYM81=LTDIE_21 - Ldebug_info_start
	.long LDIFF_SYM81
LTDIE_21_POINTER:

	.byte 13
LDIFF_SYM82=LTDIE_21 - Ldebug_info_start
	.long LDIFF_SYM82
LTDIE_21_REFERENCE:

	.byte 14
LDIFF_SYM83=LTDIE_21 - Ldebug_info_start
	.long LDIFF_SYM83
LTDIE_22:

	.byte 5
	.asciz "_ValueCollection"

	.byte 24,16
LDIFF_SYM84=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM84
	.byte 2,35,0,6
	.asciz "dictionary"

LDIFF_SYM85=LTDIE_19_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM85
	.byte 2,35,16,0,7
	.asciz "_ValueCollection"

LDIFF_SYM86=LTDIE_22 - Ldebug_info_start
	.long LDIFF_SYM86
LTDIE_22_POINTER:

	.byte 13
LDIFF_SYM87=LTDIE_22 - Ldebug_info_start
	.long LDIFF_SYM87
LTDIE_22_REFERENCE:

	.byte 14
LDIFF_SYM88=LTDIE_22 - Ldebug_info_start
	.long LDIFF_SYM88
LTDIE_19:

	.byte 5
	.asciz "System_Collections_Generic_Dictionary`2"

	.byte 72,16
LDIFF_SYM89=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM89
	.byte 2,35,0,6
	.asciz "buckets"

LDIFF_SYM90=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM90
	.byte 2,35,16,6
	.asciz "entries"

LDIFF_SYM91=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM91
	.byte 2,35,24,6
	.asciz "count"

LDIFF_SYM92=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM92
	.byte 2,35,56,6
	.asciz "version"

LDIFF_SYM93=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM93
	.byte 2,35,60,6
	.asciz "freeList"

LDIFF_SYM94=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM94
	.byte 2,35,64,6
	.asciz "freeCount"

LDIFF_SYM95=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM95
	.byte 2,35,68,6
	.asciz "comparer"

LDIFF_SYM96=LTDIE_20_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM96
	.byte 2,35,32,6
	.asciz "keys"

LDIFF_SYM97=LTDIE_21_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM97
	.byte 2,35,40,6
	.asciz "values"

LDIFF_SYM98=LTDIE_22_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM98
	.byte 2,35,48,0,7
	.asciz "System_Collections_Generic_Dictionary`2"

LDIFF_SYM99=LTDIE_19 - Ldebug_info_start
	.long LDIFF_SYM99
LTDIE_19_POINTER:

	.byte 13
LDIFF_SYM100=LTDIE_19 - Ldebug_info_start
	.long LDIFF_SYM100
LTDIE_19_REFERENCE:

	.byte 14
LDIFF_SYM101=LTDIE_19 - Ldebug_info_start
	.long LDIFF_SYM101
LTDIE_18:

	.byte 5
	.asciz "NUnit_Framework_Internal_PropertyBag"

	.byte 24,16
LDIFF_SYM102=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM102
	.byte 2,35,0,6
	.asciz "inner"

LDIFF_SYM103=LTDIE_19_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM103
	.byte 2,35,16,0,7
	.asciz "NUnit_Framework_Internal_PropertyBag"

LDIFF_SYM104=LTDIE_18 - Ldebug_info_start
	.long LDIFF_SYM104
LTDIE_18_POINTER:

	.byte 13
LDIFF_SYM105=LTDIE_18 - Ldebug_info_start
	.long LDIFF_SYM105
LTDIE_18_REFERENCE:

	.byte 14
LDIFF_SYM106=LTDIE_18 - Ldebug_info_start
	.long LDIFF_SYM106
LTDIE_24:

	.byte 5
	.asciz "System_Reflection_MemberInfo"

	.byte 16,16
LDIFF_SYM107=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM107
	.byte 2,35,0,0,7
	.asciz "System_Reflection_MemberInfo"

LDIFF_SYM108=LTDIE_24 - Ldebug_info_start
	.long LDIFF_SYM108
LTDIE_24_POINTER:

	.byte 13
LDIFF_SYM109=LTDIE_24 - Ldebug_info_start
	.long LDIFF_SYM109
LTDIE_24_REFERENCE:

	.byte 14
LDIFF_SYM110=LTDIE_24 - Ldebug_info_start
	.long LDIFF_SYM110
LTDIE_23:

	.byte 5
	.asciz "System_Type"

	.byte 24,16
LDIFF_SYM111=LTDIE_24 - Ldebug_info_start
	.long LDIFF_SYM111
	.byte 2,35,0,6
	.asciz "_impl"

LDIFF_SYM112=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM112
	.byte 2,35,16,0,7
	.asciz "System_Type"

LDIFF_SYM113=LTDIE_23 - Ldebug_info_start
	.long LDIFF_SYM113
LTDIE_23_POINTER:

	.byte 13
LDIFF_SYM114=LTDIE_23 - Ldebug_info_start
	.long LDIFF_SYM114
LTDIE_23_REFERENCE:

	.byte 14
LDIFF_SYM115=LTDIE_23 - Ldebug_info_start
	.long LDIFF_SYM115
LTDIE_13:

	.byte 5
	.asciz "NUnit_Framework_Internal_Test"

	.byte 88,16
LDIFF_SYM116=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM116
	.byte 2,35,0,6
	.asciz "id"

LDIFF_SYM117=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM117
	.byte 2,35,72,6
	.asciz "name"

LDIFF_SYM118=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM118
	.byte 2,35,16,6
	.asciz "fullName"

LDIFF_SYM119=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM119
	.byte 2,35,24,6
	.asciz "seed"

LDIFF_SYM120=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM120
	.byte 2,35,76,6
	.asciz "runState"

LDIFF_SYM121=LTDIE_16 - Ldebug_info_start
	.long LDIFF_SYM121
	.byte 2,35,80,6
	.asciz "parent"

LDIFF_SYM122=LTDIE_17_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM122
	.byte 2,35,32,6
	.asciz "properties"

LDIFF_SYM123=LTDIE_18_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM123
	.byte 2,35,40,6
	.asciz "fixtureType"

LDIFF_SYM124=LTDIE_23_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM124
	.byte 2,35,48,6
	.asciz "setUpMethods"

LDIFF_SYM125=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM125
	.byte 2,35,56,6
	.asciz "tearDownMethods"

LDIFF_SYM126=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM126
	.byte 2,35,64,0,7
	.asciz "NUnit_Framework_Internal_Test"

LDIFF_SYM127=LTDIE_13 - Ldebug_info_start
	.long LDIFF_SYM127
LTDIE_13_POINTER:

	.byte 13
LDIFF_SYM128=LTDIE_13 - Ldebug_info_start
	.long LDIFF_SYM128
LTDIE_13_REFERENCE:

	.byte 14
LDIFF_SYM129=LTDIE_13 - Ldebug_info_start
	.long LDIFF_SYM129
LTDIE_25:

	.byte 5
	.asciz "System_Collections_Generic_List`1"

	.byte 32,16
LDIFF_SYM130=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM130
	.byte 2,35,0,6
	.asciz "_items"

LDIFF_SYM131=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM131
	.byte 2,35,16,6
	.asciz "_size"

LDIFF_SYM132=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM132
	.byte 2,35,24,6
	.asciz "_version"

LDIFF_SYM133=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM133
	.byte 2,35,28,0,7
	.asciz "System_Collections_Generic_List`1"

LDIFF_SYM134=LTDIE_25 - Ldebug_info_start
	.long LDIFF_SYM134
LTDIE_25_POINTER:

	.byte 13
LDIFF_SYM135=LTDIE_25 - Ldebug_info_start
	.long LDIFF_SYM135
LTDIE_25_REFERENCE:

	.byte 14
LDIFF_SYM136=LTDIE_25 - Ldebug_info_start
	.long LDIFF_SYM136
LTDIE_26:

	.byte 5
	.asciz "System_Boolean"

	.byte 17,16
LDIFF_SYM137=LTDIE_15 - Ldebug_info_start
	.long LDIFF_SYM137
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM138=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM138
	.byte 2,35,16,0,7
	.asciz "System_Boolean"

LDIFF_SYM139=LTDIE_26 - Ldebug_info_start
	.long LDIFF_SYM139
LTDIE_26_POINTER:

	.byte 13
LDIFF_SYM140=LTDIE_26 - Ldebug_info_start
	.long LDIFF_SYM140
LTDIE_26_REFERENCE:

	.byte 14
LDIFF_SYM141=LTDIE_26 - Ldebug_info_start
	.long LDIFF_SYM141
LTDIE_12:

	.byte 5
	.asciz "NUnit_Framework_Internal_TestSuite"

	.byte 112,16
LDIFF_SYM142=LTDIE_13 - Ldebug_info_start
	.long LDIFF_SYM142
	.byte 2,35,0,6
	.asciz "tests"

LDIFF_SYM143=LTDIE_25_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM143
	.byte 2,35,88,6
	.asciz "maintainTestOrder"

LDIFF_SYM144=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM144
	.byte 2,35,104,6
	.asciz "arguments"

LDIFF_SYM145=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM145
	.byte 2,35,96,0,7
	.asciz "NUnit_Framework_Internal_TestSuite"

LDIFF_SYM146=LTDIE_12 - Ldebug_info_start
	.long LDIFF_SYM146
LTDIE_12_POINTER:

	.byte 13
LDIFF_SYM147=LTDIE_12 - Ldebug_info_start
	.long LDIFF_SYM147
LTDIE_12_REFERENCE:

	.byte 14
LDIFF_SYM148=LTDIE_12 - Ldebug_info_start
	.long LDIFF_SYM148
LTDIE_27:

	.byte 17
	.asciz "NUnit_Framework_Api_ITestFilter"

	.byte 16,7
	.asciz "NUnit_Framework_Api_ITestFilter"

LDIFF_SYM149=LTDIE_27 - Ldebug_info_start
	.long LDIFF_SYM149
LTDIE_27_POINTER:

	.byte 13
LDIFF_SYM150=LTDIE_27 - Ldebug_info_start
	.long LDIFF_SYM150
LTDIE_27_REFERENCE:

	.byte 14
LDIFF_SYM151=LTDIE_27 - Ldebug_info_start
	.long LDIFF_SYM151
LTDIE_28:

	.byte 5
	.asciz "System_Collections_Generic_List`1"

	.byte 32,16
LDIFF_SYM152=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM152
	.byte 2,35,0,6
	.asciz "_items"

LDIFF_SYM153=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM153
	.byte 2,35,16,6
	.asciz "_size"

LDIFF_SYM154=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM154
	.byte 2,35,24,6
	.asciz "_version"

LDIFF_SYM155=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM155
	.byte 2,35,28,0,7
	.asciz "System_Collections_Generic_List`1"

LDIFF_SYM156=LTDIE_28 - Ldebug_info_start
	.long LDIFF_SYM156
LTDIE_28_POINTER:

	.byte 13
LDIFF_SYM157=LTDIE_28 - Ldebug_info_start
	.long LDIFF_SYM157
LTDIE_28_REFERENCE:

	.byte 14
LDIFF_SYM158=LTDIE_28 - Ldebug_info_start
	.long LDIFF_SYM158
LTDIE_29:

	.byte 5
	.asciz "System_Collections_Generic_List`1"

	.byte 32,16
LDIFF_SYM159=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM159
	.byte 2,35,0,6
	.asciz "_items"

LDIFF_SYM160=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM160
	.byte 2,35,16,6
	.asciz "_size"

LDIFF_SYM161=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM161
	.byte 2,35,24,6
	.asciz "_version"

LDIFF_SYM162=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM162
	.byte 2,35,28,0,7
	.asciz "System_Collections_Generic_List`1"

LDIFF_SYM163=LTDIE_29 - Ldebug_info_start
	.long LDIFF_SYM163
LTDIE_29_POINTER:

	.byte 13
LDIFF_SYM164=LTDIE_29 - Ldebug_info_start
	.long LDIFF_SYM164
LTDIE_29_REFERENCE:

	.byte 14
LDIFF_SYM165=LTDIE_29 - Ldebug_info_start
	.long LDIFF_SYM165
LTDIE_32:

	.byte 8
	.asciz "NUnit_Framework_Api_TestStatus"

	.byte 4
LDIFF_SYM166=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM166
	.byte 9
	.asciz "Inconclusive"

	.byte 0,9
	.asciz "Skipped"

	.byte 1,9
	.asciz "Passed"

	.byte 2,9
	.asciz "Failed"

	.byte 3,0,7
	.asciz "NUnit_Framework_Api_TestStatus"

LDIFF_SYM167=LTDIE_32 - Ldebug_info_start
	.long LDIFF_SYM167
LTDIE_32_POINTER:

	.byte 13
LDIFF_SYM168=LTDIE_32 - Ldebug_info_start
	.long LDIFF_SYM168
LTDIE_32_REFERENCE:

	.byte 14
LDIFF_SYM169=LTDIE_32 - Ldebug_info_start
	.long LDIFF_SYM169
LTDIE_31:

	.byte 5
	.asciz "NUnit_Framework_Api_ResultState"

	.byte 32,16
LDIFF_SYM170=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM170
	.byte 2,35,0,6
	.asciz "status"

LDIFF_SYM171=LTDIE_32 - Ldebug_info_start
	.long LDIFF_SYM171
	.byte 2,35,24,6
	.asciz "label"

LDIFF_SYM172=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM172
	.byte 2,35,16,0,7
	.asciz "NUnit_Framework_Api_ResultState"

LDIFF_SYM173=LTDIE_31 - Ldebug_info_start
	.long LDIFF_SYM173
LTDIE_31_POINTER:

	.byte 13
LDIFF_SYM174=LTDIE_31 - Ldebug_info_start
	.long LDIFF_SYM174
LTDIE_31_REFERENCE:

	.byte 14
LDIFF_SYM175=LTDIE_31 - Ldebug_info_start
	.long LDIFF_SYM175
LTDIE_33:

	.byte 5
	.asciz "System_Collections_Generic_List`1"

	.byte 32,16
LDIFF_SYM176=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM176
	.byte 2,35,0,6
	.asciz "_items"

LDIFF_SYM177=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM177
	.byte 2,35,16,6
	.asciz "_size"

LDIFF_SYM178=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM178
	.byte 2,35,24,6
	.asciz "_version"

LDIFF_SYM179=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM179
	.byte 2,35,28,0,7
	.asciz "System_Collections_Generic_List`1"

LDIFF_SYM180=LTDIE_33 - Ldebug_info_start
	.long LDIFF_SYM180
LTDIE_33_POINTER:

	.byte 13
LDIFF_SYM181=LTDIE_33 - Ldebug_info_start
	.long LDIFF_SYM181
LTDIE_33_REFERENCE:

	.byte 14
LDIFF_SYM182=LTDIE_33 - Ldebug_info_start
	.long LDIFF_SYM182
LTDIE_30:

	.byte 5
	.asciz "NUnit_Framework_Internal_TestResult"

	.byte 72,16
LDIFF_SYM183=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM183
	.byte 2,35,0,6
	.asciz "resultState"

LDIFF_SYM184=LTDIE_31_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM184
	.byte 2,35,16,6
	.asciz "time"

LDIFF_SYM185=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM185
	.byte 2,35,56,6
	.asciz "test"

LDIFF_SYM186=LTDIE_17_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM186
	.byte 2,35,24,6
	.asciz "stackTrace"

LDIFF_SYM187=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM187
	.byte 2,35,32,6
	.asciz "message"

LDIFF_SYM188=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM188
	.byte 2,35,40,6
	.asciz "assertCount"

LDIFF_SYM189=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM189
	.byte 2,35,64,6
	.asciz "ThreadCrashFail"

LDIFF_SYM190=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM190
	.byte 2,35,68,6
	.asciz "children"

LDIFF_SYM191=LTDIE_33_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM191
	.byte 2,35,48,0,7
	.asciz "NUnit_Framework_Internal_TestResult"

LDIFF_SYM192=LTDIE_30 - Ldebug_info_start
	.long LDIFF_SYM192
LTDIE_30_POINTER:

	.byte 13
LDIFF_SYM193=LTDIE_30 - Ldebug_info_start
	.long LDIFF_SYM193
LTDIE_30_REFERENCE:

	.byte 14
LDIFF_SYM194=LTDIE_30 - Ldebug_info_start
	.long LDIFF_SYM194
LTDIE_35:

	.byte 5
	.asciz "System_MarshalByRefObject"

	.byte 24,16
LDIFF_SYM195=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM195
	.byte 2,35,0,6
	.asciz "_identity"

LDIFF_SYM196=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM196
	.byte 2,35,16,0,7
	.asciz "System_MarshalByRefObject"

LDIFF_SYM197=LTDIE_35 - Ldebug_info_start
	.long LDIFF_SYM197
LTDIE_35_POINTER:

	.byte 13
LDIFF_SYM198=LTDIE_35 - Ldebug_info_start
	.long LDIFF_SYM198
LTDIE_35_REFERENCE:

	.byte 14
LDIFF_SYM199=LTDIE_35 - Ldebug_info_start
	.long LDIFF_SYM199
LTDIE_36:

	.byte 17
	.asciz "System_IFormatProvider"

	.byte 16,7
	.asciz "System_IFormatProvider"

LDIFF_SYM200=LTDIE_36 - Ldebug_info_start
	.long LDIFF_SYM200
LTDIE_36_POINTER:

	.byte 13
LDIFF_SYM201=LTDIE_36 - Ldebug_info_start
	.long LDIFF_SYM201
LTDIE_36_REFERENCE:

	.byte 14
LDIFF_SYM202=LTDIE_36 - Ldebug_info_start
	.long LDIFF_SYM202
LTDIE_34:

	.byte 5
	.asciz "System_IO_TextWriter"

	.byte 40,16
LDIFF_SYM203=LTDIE_35 - Ldebug_info_start
	.long LDIFF_SYM203
	.byte 2,35,0,6
	.asciz "CoreNewLine"

LDIFF_SYM204=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM204
	.byte 2,35,24,6
	.asciz "InternalFormatProvider"

LDIFF_SYM205=LTDIE_36_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM205
	.byte 2,35,32,0,7
	.asciz "System_IO_TextWriter"

LDIFF_SYM206=LTDIE_34 - Ldebug_info_start
	.long LDIFF_SYM206
LTDIE_34_POINTER:

	.byte 13
LDIFF_SYM207=LTDIE_34 - Ldebug_info_start
	.long LDIFF_SYM207
LTDIE_34_REFERENCE:

	.byte 14
LDIFF_SYM208=LTDIE_34 - Ldebug_info_start
	.long LDIFF_SYM208
LTDIE_38:

	.byte 5
	.asciz "System_Threading_Tasks_TaskScheduler"

	.byte 20,16
LDIFF_SYM209=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM209
	.byte 2,35,0,6
	.asciz "m_taskSchedulerId"

LDIFF_SYM210=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM210
	.byte 2,35,16,0,7
	.asciz "System_Threading_Tasks_TaskScheduler"

LDIFF_SYM211=LTDIE_38 - Ldebug_info_start
	.long LDIFF_SYM211
LTDIE_38_POINTER:

	.byte 13
LDIFF_SYM212=LTDIE_38 - Ldebug_info_start
	.long LDIFF_SYM212
LTDIE_38_REFERENCE:

	.byte 14
LDIFF_SYM213=LTDIE_38 - Ldebug_info_start
	.long LDIFF_SYM213
LTDIE_41:

	.byte 5
	.asciz "System_Threading_SynchronizationContext"

	.byte 16,16
LDIFF_SYM214=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM214
	.byte 2,35,0,0,7
	.asciz "System_Threading_SynchronizationContext"

LDIFF_SYM215=LTDIE_41 - Ldebug_info_start
	.long LDIFF_SYM215
LTDIE_41_POINTER:

	.byte 13
LDIFF_SYM216=LTDIE_41 - Ldebug_info_start
	.long LDIFF_SYM216
LTDIE_41_REFERENCE:

	.byte 14
LDIFF_SYM217=LTDIE_41 - Ldebug_info_start
	.long LDIFF_SYM217
LTDIE_44:

	.byte 5
	.asciz "System_Single"

	.byte 20,16
LDIFF_SYM218=LTDIE_15 - Ldebug_info_start
	.long LDIFF_SYM218
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM219=LDIE_R4 - Ldebug_info_start
	.long LDIFF_SYM219
	.byte 2,35,16,0,7
	.asciz "System_Single"

LDIFF_SYM220=LTDIE_44 - Ldebug_info_start
	.long LDIFF_SYM220
LTDIE_44_POINTER:

	.byte 13
LDIFF_SYM221=LTDIE_44 - Ldebug_info_start
	.long LDIFF_SYM221
LTDIE_44_REFERENCE:

	.byte 14
LDIFF_SYM222=LTDIE_44 - Ldebug_info_start
	.long LDIFF_SYM222
LTDIE_45:

	.byte 17
	.asciz "System_Collections_ICollection"

	.byte 16,7
	.asciz "System_Collections_ICollection"

LDIFF_SYM223=LTDIE_45 - Ldebug_info_start
	.long LDIFF_SYM223
LTDIE_45_POINTER:

	.byte 13
LDIFF_SYM224=LTDIE_45 - Ldebug_info_start
	.long LDIFF_SYM224
LTDIE_45_REFERENCE:

	.byte 14
LDIFF_SYM225=LTDIE_45 - Ldebug_info_start
	.long LDIFF_SYM225
LTDIE_46:

	.byte 17
	.asciz "System_Collections_IEqualityComparer"

	.byte 16,7
	.asciz "System_Collections_IEqualityComparer"

LDIFF_SYM226=LTDIE_46 - Ldebug_info_start
	.long LDIFF_SYM226
LTDIE_46_POINTER:

	.byte 13
LDIFF_SYM227=LTDIE_46 - Ldebug_info_start
	.long LDIFF_SYM227
LTDIE_46_REFERENCE:

	.byte 14
LDIFF_SYM228=LTDIE_46 - Ldebug_info_start
	.long LDIFF_SYM228
LTDIE_43:

	.byte 5
	.asciz "System_Collections_Hashtable"

	.byte 72,16
LDIFF_SYM229=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM229
	.byte 2,35,0,6
	.asciz "buckets"

LDIFF_SYM230=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM230
	.byte 2,35,16,6
	.asciz "count"

LDIFF_SYM231=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM231
	.byte 2,35,48,6
	.asciz "occupancy"

LDIFF_SYM232=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM232
	.byte 2,35,52,6
	.asciz "loadsize"

LDIFF_SYM233=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM233
	.byte 2,35,56,6
	.asciz "loadFactor"

LDIFF_SYM234=LDIE_R4 - Ldebug_info_start
	.long LDIFF_SYM234
	.byte 2,35,60,6
	.asciz "version"

LDIFF_SYM235=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM235
	.byte 2,35,64,6
	.asciz "isWriterInProgress"

LDIFF_SYM236=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM236
	.byte 2,35,68,6
	.asciz "keys"

LDIFF_SYM237=LTDIE_45_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM237
	.byte 2,35,24,6
	.asciz "_keycomparer"

LDIFF_SYM238=LTDIE_46_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM238
	.byte 2,35,32,6
	.asciz "_syncRoot"

LDIFF_SYM239=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM239
	.byte 2,35,40,0,7
	.asciz "System_Collections_Hashtable"

LDIFF_SYM240=LTDIE_43 - Ldebug_info_start
	.long LDIFF_SYM240
LTDIE_43_POINTER:

	.byte 13
LDIFF_SYM241=LTDIE_43 - Ldebug_info_start
	.long LDIFF_SYM241
LTDIE_43_REFERENCE:

	.byte 14
LDIFF_SYM242=LTDIE_43 - Ldebug_info_start
	.long LDIFF_SYM242
LTDIE_47:

	.byte 5
	.asciz "System_Runtime_Remoting_Messaging_CallContextRemotingData"

	.byte 16,16
LDIFF_SYM243=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM243
	.byte 2,35,0,0,7
	.asciz "System_Runtime_Remoting_Messaging_CallContextRemotingData"

LDIFF_SYM244=LTDIE_47 - Ldebug_info_start
	.long LDIFF_SYM244
LTDIE_47_POINTER:

	.byte 13
LDIFF_SYM245=LTDIE_47 - Ldebug_info_start
	.long LDIFF_SYM245
LTDIE_47_REFERENCE:

	.byte 14
LDIFF_SYM246=LTDIE_47 - Ldebug_info_start
	.long LDIFF_SYM246
LTDIE_48:

	.byte 5
	.asciz "System_Runtime_Remoting_Messaging_CallContextSecurityData"

	.byte 16,16
LDIFF_SYM247=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM247
	.byte 2,35,0,0,7
	.asciz "System_Runtime_Remoting_Messaging_CallContextSecurityData"

LDIFF_SYM248=LTDIE_48 - Ldebug_info_start
	.long LDIFF_SYM248
LTDIE_48_POINTER:

	.byte 13
LDIFF_SYM249=LTDIE_48 - Ldebug_info_start
	.long LDIFF_SYM249
LTDIE_48_REFERENCE:

	.byte 14
LDIFF_SYM250=LTDIE_48 - Ldebug_info_start
	.long LDIFF_SYM250
LTDIE_42:

	.byte 5
	.asciz "System_Runtime_Remoting_Messaging_LogicalCallContext"

	.byte 56,16
LDIFF_SYM251=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM251
	.byte 2,35,0,6
	.asciz "m_Datastore"

LDIFF_SYM252=LTDIE_43_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM252
	.byte 2,35,16,6
	.asciz "m_RemotingData"

LDIFF_SYM253=LTDIE_47_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM253
	.byte 2,35,24,6
	.asciz "m_SecurityData"

LDIFF_SYM254=LTDIE_48_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM254
	.byte 2,35,32,6
	.asciz "m_HostContext"

LDIFF_SYM255=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM255
	.byte 2,35,40,6
	.asciz "m_IsCorrelationMgr"

LDIFF_SYM256=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM256
	.byte 2,35,48,0,7
	.asciz "System_Runtime_Remoting_Messaging_LogicalCallContext"

LDIFF_SYM257=LTDIE_42 - Ldebug_info_start
	.long LDIFF_SYM257
LTDIE_42_POINTER:

	.byte 13
LDIFF_SYM258=LTDIE_42 - Ldebug_info_start
	.long LDIFF_SYM258
LTDIE_42_REFERENCE:

	.byte 14
LDIFF_SYM259=LTDIE_42 - Ldebug_info_start
	.long LDIFF_SYM259
LTDIE_49:

	.byte 5
	.asciz "System_Runtime_Remoting_Messaging_IllogicalCallContext"

	.byte 16,16
LDIFF_SYM260=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM260
	.byte 2,35,0,0,7
	.asciz "System_Runtime_Remoting_Messaging_IllogicalCallContext"

LDIFF_SYM261=LTDIE_49 - Ldebug_info_start
	.long LDIFF_SYM261
LTDIE_49_POINTER:

	.byte 13
LDIFF_SYM262=LTDIE_49 - Ldebug_info_start
	.long LDIFF_SYM262
LTDIE_49_REFERENCE:

	.byte 14
LDIFF_SYM263=LTDIE_49 - Ldebug_info_start
	.long LDIFF_SYM263
LTDIE_50:

	.byte 8
	.asciz "_Flags"

	.byte 4
LDIFF_SYM264=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM264
	.byte 9
	.asciz "None"

	.byte 0,9
	.asciz "IsNewCapture"

	.byte 1,9
	.asciz "IsFlowSuppressed"

	.byte 2,9
	.asciz "IsPreAllocatedDefault"

	.byte 4,0,7
	.asciz "_Flags"

LDIFF_SYM265=LTDIE_50 - Ldebug_info_start
	.long LDIFF_SYM265
LTDIE_50_POINTER:

	.byte 13
LDIFF_SYM266=LTDIE_50 - Ldebug_info_start
	.long LDIFF_SYM266
LTDIE_50_REFERENCE:

	.byte 14
LDIFF_SYM267=LTDIE_50 - Ldebug_info_start
	.long LDIFF_SYM267
LTDIE_52:

	.byte 17
	.asciz "System_Collections_Generic_IEqualityComparer`1"

	.byte 16,7
	.asciz "System_Collections_Generic_IEqualityComparer`1"

LDIFF_SYM268=LTDIE_52 - Ldebug_info_start
	.long LDIFF_SYM268
LTDIE_52_POINTER:

	.byte 13
LDIFF_SYM269=LTDIE_52 - Ldebug_info_start
	.long LDIFF_SYM269
LTDIE_52_REFERENCE:

	.byte 14
LDIFF_SYM270=LTDIE_52 - Ldebug_info_start
	.long LDIFF_SYM270
LTDIE_53:

	.byte 5
	.asciz "_KeyCollection"

	.byte 24,16
LDIFF_SYM271=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM271
	.byte 2,35,0,6
	.asciz "dictionary"

LDIFF_SYM272=LTDIE_51_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM272
	.byte 2,35,16,0,7
	.asciz "_KeyCollection"

LDIFF_SYM273=LTDIE_53 - Ldebug_info_start
	.long LDIFF_SYM273
LTDIE_53_POINTER:

	.byte 13
LDIFF_SYM274=LTDIE_53 - Ldebug_info_start
	.long LDIFF_SYM274
LTDIE_53_REFERENCE:

	.byte 14
LDIFF_SYM275=LTDIE_53 - Ldebug_info_start
	.long LDIFF_SYM275
LTDIE_54:

	.byte 5
	.asciz "_ValueCollection"

	.byte 24,16
LDIFF_SYM276=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM276
	.byte 2,35,0,6
	.asciz "dictionary"

LDIFF_SYM277=LTDIE_51_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM277
	.byte 2,35,16,0,7
	.asciz "_ValueCollection"

LDIFF_SYM278=LTDIE_54 - Ldebug_info_start
	.long LDIFF_SYM278
LTDIE_54_POINTER:

	.byte 13
LDIFF_SYM279=LTDIE_54 - Ldebug_info_start
	.long LDIFF_SYM279
LTDIE_54_REFERENCE:

	.byte 14
LDIFF_SYM280=LTDIE_54 - Ldebug_info_start
	.long LDIFF_SYM280
LTDIE_51:

	.byte 5
	.asciz "System_Collections_Generic_Dictionary`2"

	.byte 72,16
LDIFF_SYM281=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM281
	.byte 2,35,0,6
	.asciz "buckets"

LDIFF_SYM282=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM282
	.byte 2,35,16,6
	.asciz "entries"

LDIFF_SYM283=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM283
	.byte 2,35,24,6
	.asciz "count"

LDIFF_SYM284=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM284
	.byte 2,35,56,6
	.asciz "version"

LDIFF_SYM285=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM285
	.byte 2,35,60,6
	.asciz "freeList"

LDIFF_SYM286=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM286
	.byte 2,35,64,6
	.asciz "freeCount"

LDIFF_SYM287=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM287
	.byte 2,35,68,6
	.asciz "comparer"

LDIFF_SYM288=LTDIE_52_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM288
	.byte 2,35,32,6
	.asciz "keys"

LDIFF_SYM289=LTDIE_53_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM289
	.byte 2,35,40,6
	.asciz "values"

LDIFF_SYM290=LTDIE_54_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM290
	.byte 2,35,48,0,7
	.asciz "System_Collections_Generic_Dictionary`2"

LDIFF_SYM291=LTDIE_51 - Ldebug_info_start
	.long LDIFF_SYM291
LTDIE_51_POINTER:

	.byte 13
LDIFF_SYM292=LTDIE_51 - Ldebug_info_start
	.long LDIFF_SYM292
LTDIE_51_REFERENCE:

	.byte 14
LDIFF_SYM293=LTDIE_51 - Ldebug_info_start
	.long LDIFF_SYM293
LTDIE_55:

	.byte 5
	.asciz "System_Collections_Generic_List`1"

	.byte 32,16
LDIFF_SYM294=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM294
	.byte 2,35,0,6
	.asciz "_items"

LDIFF_SYM295=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM295
	.byte 2,35,16,6
	.asciz "_size"

LDIFF_SYM296=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM296
	.byte 2,35,24,6
	.asciz "_version"

LDIFF_SYM297=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM297
	.byte 2,35,28,0,7
	.asciz "System_Collections_Generic_List`1"

LDIFF_SYM298=LTDIE_55 - Ldebug_info_start
	.long LDIFF_SYM298
LTDIE_55_POINTER:

	.byte 13
LDIFF_SYM299=LTDIE_55 - Ldebug_info_start
	.long LDIFF_SYM299
LTDIE_55_REFERENCE:

	.byte 14
LDIFF_SYM300=LTDIE_55 - Ldebug_info_start
	.long LDIFF_SYM300
LTDIE_40:

	.byte 5
	.asciz "System_Threading_ExecutionContext"

	.byte 72,16
LDIFF_SYM301=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM301
	.byte 2,35,0,6
	.asciz "_syncContext"

LDIFF_SYM302=LTDIE_41_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM302
	.byte 2,35,16,6
	.asciz "_syncContextNoFlow"

LDIFF_SYM303=LTDIE_41_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM303
	.byte 2,35,24,6
	.asciz "_logicalCallContext"

LDIFF_SYM304=LTDIE_42_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM304
	.byte 2,35,32,6
	.asciz "_illogicalCallContext"

LDIFF_SYM305=LTDIE_49_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM305
	.byte 2,35,40,6
	.asciz "_flags"

LDIFF_SYM306=LTDIE_50 - Ldebug_info_start
	.long LDIFF_SYM306
	.byte 2,35,64,6
	.asciz "_localValues"

LDIFF_SYM307=LTDIE_51_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM307
	.byte 2,35,48,6
	.asciz "_localChangeNotifications"

LDIFF_SYM308=LTDIE_55_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM308
	.byte 2,35,56,0,7
	.asciz "System_Threading_ExecutionContext"

LDIFF_SYM309=LTDIE_40 - Ldebug_info_start
	.long LDIFF_SYM309
LTDIE_40_POINTER:

	.byte 13
LDIFF_SYM310=LTDIE_40 - Ldebug_info_start
	.long LDIFF_SYM310
LTDIE_40_REFERENCE:

	.byte 14
LDIFF_SYM311=LTDIE_40 - Ldebug_info_start
	.long LDIFF_SYM311
LTDIE_63:

	.byte 5
	.asciz "System_Runtime_ConstrainedExecution_CriticalFinalizerObject"

	.byte 16,16
LDIFF_SYM312=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM312
	.byte 2,35,0,0,7
	.asciz "System_Runtime_ConstrainedExecution_CriticalFinalizerObject"

LDIFF_SYM313=LTDIE_63 - Ldebug_info_start
	.long LDIFF_SYM313
LTDIE_63_POINTER:

	.byte 13
LDIFF_SYM314=LTDIE_63 - Ldebug_info_start
	.long LDIFF_SYM314
LTDIE_63_REFERENCE:

	.byte 14
LDIFF_SYM315=LTDIE_63 - Ldebug_info_start
	.long LDIFF_SYM315
LTDIE_62:

	.byte 5
	.asciz "System_Runtime_InteropServices_SafeHandle"

	.byte 32,16
LDIFF_SYM316=LTDIE_63 - Ldebug_info_start
	.long LDIFF_SYM316
	.byte 2,35,0,6
	.asciz "handle"

LDIFF_SYM317=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM317
	.byte 2,35,16,6
	.asciz "_state"

LDIFF_SYM318=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM318
	.byte 2,35,24,6
	.asciz "_ownsHandle"

LDIFF_SYM319=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM319
	.byte 2,35,28,6
	.asciz "_fullyInitialized"

LDIFF_SYM320=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM320
	.byte 2,35,29,0,7
	.asciz "System_Runtime_InteropServices_SafeHandle"

LDIFF_SYM321=LTDIE_62 - Ldebug_info_start
	.long LDIFF_SYM321
LTDIE_62_POINTER:

	.byte 13
LDIFF_SYM322=LTDIE_62 - Ldebug_info_start
	.long LDIFF_SYM322
LTDIE_62_REFERENCE:

	.byte 14
LDIFF_SYM323=LTDIE_62 - Ldebug_info_start
	.long LDIFF_SYM323
LTDIE_61:

	.byte 5
	.asciz "Microsoft_Win32_SafeHandles_SafeHandleZeroOrMinusOneIsInvalid"

	.byte 32,16
LDIFF_SYM324=LTDIE_62 - Ldebug_info_start
	.long LDIFF_SYM324
	.byte 2,35,0,0,7
	.asciz "Microsoft_Win32_SafeHandles_SafeHandleZeroOrMinusOneIsInvalid"

LDIFF_SYM325=LTDIE_61 - Ldebug_info_start
	.long LDIFF_SYM325
LTDIE_61_POINTER:

	.byte 13
LDIFF_SYM326=LTDIE_61 - Ldebug_info_start
	.long LDIFF_SYM326
LTDIE_61_REFERENCE:

	.byte 14
LDIFF_SYM327=LTDIE_61 - Ldebug_info_start
	.long LDIFF_SYM327
LTDIE_60:

	.byte 5
	.asciz "Microsoft_Win32_SafeHandles_SafeWaitHandle"

	.byte 32,16
LDIFF_SYM328=LTDIE_61 - Ldebug_info_start
	.long LDIFF_SYM328
	.byte 2,35,0,0,7
	.asciz "Microsoft_Win32_SafeHandles_SafeWaitHandle"

LDIFF_SYM329=LTDIE_60 - Ldebug_info_start
	.long LDIFF_SYM329
LTDIE_60_POINTER:

	.byte 13
LDIFF_SYM330=LTDIE_60 - Ldebug_info_start
	.long LDIFF_SYM330
LTDIE_60_REFERENCE:

	.byte 14
LDIFF_SYM331=LTDIE_60 - Ldebug_info_start
	.long LDIFF_SYM331
LTDIE_59:

	.byte 5
	.asciz "System_Threading_WaitHandle"

	.byte 48,16
LDIFF_SYM332=LTDIE_35 - Ldebug_info_start
	.long LDIFF_SYM332
	.byte 2,35,0,6
	.asciz "waitHandle"

LDIFF_SYM333=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM333
	.byte 2,35,24,6
	.asciz "safeWaitHandle"

LDIFF_SYM334=LTDIE_60_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM334
	.byte 2,35,32,6
	.asciz "hasThreadAffinity"

LDIFF_SYM335=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM335
	.byte 2,35,40,0,7
	.asciz "System_Threading_WaitHandle"

LDIFF_SYM336=LTDIE_59 - Ldebug_info_start
	.long LDIFF_SYM336
LTDIE_59_POINTER:

	.byte 13
LDIFF_SYM337=LTDIE_59 - Ldebug_info_start
	.long LDIFF_SYM337
LTDIE_59_REFERENCE:

	.byte 14
LDIFF_SYM338=LTDIE_59 - Ldebug_info_start
	.long LDIFF_SYM338
LTDIE_58:

	.byte 5
	.asciz "System_Threading_EventWaitHandle"

	.byte 48,16
LDIFF_SYM339=LTDIE_59 - Ldebug_info_start
	.long LDIFF_SYM339
	.byte 2,35,0,0,7
	.asciz "System_Threading_EventWaitHandle"

LDIFF_SYM340=LTDIE_58 - Ldebug_info_start
	.long LDIFF_SYM340
LTDIE_58_POINTER:

	.byte 13
LDIFF_SYM341=LTDIE_58 - Ldebug_info_start
	.long LDIFF_SYM341
LTDIE_58_REFERENCE:

	.byte 14
LDIFF_SYM342=LTDIE_58 - Ldebug_info_start
	.long LDIFF_SYM342
LTDIE_57:

	.byte 5
	.asciz "System_Threading_ManualResetEvent"

	.byte 48,16
LDIFF_SYM343=LTDIE_58 - Ldebug_info_start
	.long LDIFF_SYM343
	.byte 2,35,0,0,7
	.asciz "System_Threading_ManualResetEvent"

LDIFF_SYM344=LTDIE_57 - Ldebug_info_start
	.long LDIFF_SYM344
LTDIE_57_POINTER:

	.byte 13
LDIFF_SYM345=LTDIE_57 - Ldebug_info_start
	.long LDIFF_SYM345
LTDIE_57_REFERENCE:

	.byte 14
LDIFF_SYM346=LTDIE_57 - Ldebug_info_start
	.long LDIFF_SYM346
LTDIE_56:

	.byte 5
	.asciz "System_Threading_ManualResetEventSlim"

	.byte 40,16
LDIFF_SYM347=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM347
	.byte 2,35,0,6
	.asciz "m_lock"

LDIFF_SYM348=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM348
	.byte 2,35,16,6
	.asciz "m_eventObj"

LDIFF_SYM349=LTDIE_57_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM349
	.byte 2,35,24,6
	.asciz "m_combinedState"

LDIFF_SYM350=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM350
	.byte 2,35,32,0,7
	.asciz "System_Threading_ManualResetEventSlim"

LDIFF_SYM351=LTDIE_56 - Ldebug_info_start
	.long LDIFF_SYM351
LTDIE_56_POINTER:

	.byte 13
LDIFF_SYM352=LTDIE_56 - Ldebug_info_start
	.long LDIFF_SYM352
LTDIE_56_REFERENCE:

	.byte 14
LDIFF_SYM353=LTDIE_56 - Ldebug_info_start
	.long LDIFF_SYM353
LTDIE_65:

	.byte 5
	.asciz "System_Collections_Generic_List`1"

	.byte 32,16
LDIFF_SYM354=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM354
	.byte 2,35,0,6
	.asciz "_items"

LDIFF_SYM355=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM355
	.byte 2,35,16,6
	.asciz "_size"

LDIFF_SYM356=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM356
	.byte 2,35,24,6
	.asciz "_version"

LDIFF_SYM357=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM357
	.byte 2,35,28,0,7
	.asciz "System_Collections_Generic_List`1"

LDIFF_SYM358=LTDIE_65 - Ldebug_info_start
	.long LDIFF_SYM358
LTDIE_65_POINTER:

	.byte 13
LDIFF_SYM359=LTDIE_65 - Ldebug_info_start
	.long LDIFF_SYM359
LTDIE_65_REFERENCE:

	.byte 14
LDIFF_SYM360=LTDIE_65 - Ldebug_info_start
	.long LDIFF_SYM360
LTDIE_68:

	.byte 17
	.asciz "System_Collections_IDictionary"

	.byte 16,7
	.asciz "System_Collections_IDictionary"

LDIFF_SYM361=LTDIE_68 - Ldebug_info_start
	.long LDIFF_SYM361
LTDIE_68_POINTER:

	.byte 13
LDIFF_SYM362=LTDIE_68 - Ldebug_info_start
	.long LDIFF_SYM362
LTDIE_68_REFERENCE:

	.byte 14
LDIFF_SYM363=LTDIE_68 - Ldebug_info_start
	.long LDIFF_SYM363
LTDIE_70:

	.byte 17
	.asciz "System_Collections_Generic_IList`1"

	.byte 16,7
	.asciz "System_Collections_Generic_IList`1"

LDIFF_SYM364=LTDIE_70 - Ldebug_info_start
	.long LDIFF_SYM364
LTDIE_70_POINTER:

	.byte 13
LDIFF_SYM365=LTDIE_70 - Ldebug_info_start
	.long LDIFF_SYM365
LTDIE_70_REFERENCE:

	.byte 14
LDIFF_SYM366=LTDIE_70 - Ldebug_info_start
	.long LDIFF_SYM366
LTDIE_75:

	.byte 5
	.asciz "System_Reflection_MethodBase"

	.byte 16,16
LDIFF_SYM367=LTDIE_24 - Ldebug_info_start
	.long LDIFF_SYM367
	.byte 2,35,0,0,7
	.asciz "System_Reflection_MethodBase"

LDIFF_SYM368=LTDIE_75 - Ldebug_info_start
	.long LDIFF_SYM368
LTDIE_75_POINTER:

	.byte 13
LDIFF_SYM369=LTDIE_75 - Ldebug_info_start
	.long LDIFF_SYM369
LTDIE_75_REFERENCE:

	.byte 14
LDIFF_SYM370=LTDIE_75 - Ldebug_info_start
	.long LDIFF_SYM370
LTDIE_74:

	.byte 5
	.asciz "System_Reflection_MethodInfo"

	.byte 16,16
LDIFF_SYM371=LTDIE_75 - Ldebug_info_start
	.long LDIFF_SYM371
	.byte 2,35,0,0,7
	.asciz "System_Reflection_MethodInfo"

LDIFF_SYM372=LTDIE_74 - Ldebug_info_start
	.long LDIFF_SYM372
LTDIE_74_POINTER:

	.byte 13
LDIFF_SYM373=LTDIE_74 - Ldebug_info_start
	.long LDIFF_SYM373
LTDIE_74_REFERENCE:

	.byte 14
LDIFF_SYM374=LTDIE_74 - Ldebug_info_start
	.long LDIFF_SYM374
LTDIE_76:

	.byte 5
	.asciz "System_DelegateData"

	.byte 40,16
LDIFF_SYM375=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM375
	.byte 2,35,0,6
	.asciz "target_type"

LDIFF_SYM376=LTDIE_23_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM376
	.byte 2,35,16,6
	.asciz "method_name"

LDIFF_SYM377=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM377
	.byte 2,35,24,6
	.asciz "curried_first_arg"

LDIFF_SYM378=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM378
	.byte 2,35,32,0,7
	.asciz "System_DelegateData"

LDIFF_SYM379=LTDIE_76 - Ldebug_info_start
	.long LDIFF_SYM379
LTDIE_76_POINTER:

	.byte 13
LDIFF_SYM380=LTDIE_76 - Ldebug_info_start
	.long LDIFF_SYM380
LTDIE_76_REFERENCE:

	.byte 14
LDIFF_SYM381=LTDIE_76 - Ldebug_info_start
	.long LDIFF_SYM381
LTDIE_73:

	.byte 5
	.asciz "System_Delegate"

	.byte 104,16
LDIFF_SYM382=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM382
	.byte 2,35,0,6
	.asciz "method_ptr"

LDIFF_SYM383=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM383
	.byte 2,35,16,6
	.asciz "invoke_impl"

LDIFF_SYM384=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM384
	.byte 2,35,24,6
	.asciz "m_target"

LDIFF_SYM385=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM385
	.byte 2,35,32,6
	.asciz "method"

LDIFF_SYM386=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM386
	.byte 2,35,40,6
	.asciz "delegate_trampoline"

LDIFF_SYM387=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM387
	.byte 2,35,48,6
	.asciz "extra_arg"

LDIFF_SYM388=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM388
	.byte 2,35,56,6
	.asciz "method_code"

LDIFF_SYM389=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM389
	.byte 2,35,64,6
	.asciz "method_info"

LDIFF_SYM390=LTDIE_74_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM390
	.byte 2,35,72,6
	.asciz "original_method_info"

LDIFF_SYM391=LTDIE_74_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM391
	.byte 2,35,80,6
	.asciz "data"

LDIFF_SYM392=LTDIE_76_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM392
	.byte 2,35,88,6
	.asciz "method_is_virtual"

LDIFF_SYM393=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM393
	.byte 2,35,96,0,7
	.asciz "System_Delegate"

LDIFF_SYM394=LTDIE_73 - Ldebug_info_start
	.long LDIFF_SYM394
LTDIE_73_POINTER:

	.byte 13
LDIFF_SYM395=LTDIE_73 - Ldebug_info_start
	.long LDIFF_SYM395
LTDIE_73_REFERENCE:

	.byte 14
LDIFF_SYM396=LTDIE_73 - Ldebug_info_start
	.long LDIFF_SYM396
LTDIE_72:

	.byte 5
	.asciz "System_MulticastDelegate"

	.byte 112,16
LDIFF_SYM397=LTDIE_73 - Ldebug_info_start
	.long LDIFF_SYM397
	.byte 2,35,0,6
	.asciz "delegates"

LDIFF_SYM398=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM398
	.byte 2,35,104,0,7
	.asciz "System_MulticastDelegate"

LDIFF_SYM399=LTDIE_72 - Ldebug_info_start
	.long LDIFF_SYM399
LTDIE_72_POINTER:

	.byte 13
LDIFF_SYM400=LTDIE_72 - Ldebug_info_start
	.long LDIFF_SYM400
LTDIE_72_REFERENCE:

	.byte 14
LDIFF_SYM401=LTDIE_72 - Ldebug_info_start
	.long LDIFF_SYM401
LTDIE_71:

	.byte 5
	.asciz "System_EventHandler`1"

	.byte 112,16
LDIFF_SYM402=LTDIE_72 - Ldebug_info_start
	.long LDIFF_SYM402
	.byte 2,35,0,0,7
	.asciz "System_EventHandler`1"

LDIFF_SYM403=LTDIE_71 - Ldebug_info_start
	.long LDIFF_SYM403
LTDIE_71_POINTER:

	.byte 13
LDIFF_SYM404=LTDIE_71 - Ldebug_info_start
	.long LDIFF_SYM404
LTDIE_71_REFERENCE:

	.byte 14
LDIFF_SYM405=LTDIE_71 - Ldebug_info_start
	.long LDIFF_SYM405
LTDIE_69:

	.byte 5
	.asciz "System_Runtime_Serialization_SafeSerializationManager"

	.byte 40,16
LDIFF_SYM406=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM406
	.byte 2,35,0,6
	.asciz "m_serializedStates"

LDIFF_SYM407=LTDIE_70_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM407
	.byte 2,35,16,6
	.asciz "m_realObject"

LDIFF_SYM408=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM408
	.byte 2,35,24,6
	.asciz "SerializeObjectState"

LDIFF_SYM409=LTDIE_71_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM409
	.byte 2,35,32,0,7
	.asciz "System_Runtime_Serialization_SafeSerializationManager"

LDIFF_SYM410=LTDIE_69 - Ldebug_info_start
	.long LDIFF_SYM410
LTDIE_69_POINTER:

	.byte 13
LDIFF_SYM411=LTDIE_69 - Ldebug_info_start
	.long LDIFF_SYM411
LTDIE_69_REFERENCE:

	.byte 14
LDIFF_SYM412=LTDIE_69 - Ldebug_info_start
	.long LDIFF_SYM412
LTDIE_67:

	.byte 5
	.asciz "System_Exception"

	.byte 136,1,16
LDIFF_SYM413=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM413
	.byte 2,35,0,6
	.asciz "_className"

LDIFF_SYM414=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM414
	.byte 2,35,16,6
	.asciz "_message"

LDIFF_SYM415=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM415
	.byte 2,35,24,6
	.asciz "_data"

LDIFF_SYM416=LTDIE_68_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM416
	.byte 2,35,32,6
	.asciz "_innerException"

LDIFF_SYM417=LTDIE_67_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM417
	.byte 2,35,40,6
	.asciz "_helpURL"

LDIFF_SYM418=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM418
	.byte 2,35,48,6
	.asciz "_stackTrace"

LDIFF_SYM419=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM419
	.byte 2,35,56,6
	.asciz "_stackTraceString"

LDIFF_SYM420=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM420
	.byte 2,35,64,6
	.asciz "_remoteStackTraceString"

LDIFF_SYM421=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM421
	.byte 2,35,72,6
	.asciz "_remoteStackIndex"

LDIFF_SYM422=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM422
	.byte 2,35,80,6
	.asciz "_dynamicMethods"

LDIFF_SYM423=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM423
	.byte 2,35,88,6
	.asciz "_HResult"

LDIFF_SYM424=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM424
	.byte 2,35,96,6
	.asciz "_source"

LDIFF_SYM425=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM425
	.byte 2,35,104,6
	.asciz "_safeSerializationManager"

LDIFF_SYM426=LTDIE_69_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM426
	.byte 2,35,112,6
	.asciz "captured_traces"

LDIFF_SYM427=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM427
	.byte 2,35,120,6
	.asciz "native_trace_ips"

LDIFF_SYM428=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM428
	.byte 3,35,128,1,0,7
	.asciz "System_Exception"

LDIFF_SYM429=LTDIE_67 - Ldebug_info_start
	.long LDIFF_SYM429
LTDIE_67_POINTER:

	.byte 13
LDIFF_SYM430=LTDIE_67 - Ldebug_info_start
	.long LDIFF_SYM430
LTDIE_67_REFERENCE:

	.byte 14
LDIFF_SYM431=LTDIE_67 - Ldebug_info_start
	.long LDIFF_SYM431
LTDIE_66:

	.byte 5
	.asciz "System_Runtime_ExceptionServices_ExceptionDispatchInfo"

	.byte 32,16
LDIFF_SYM432=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM432
	.byte 2,35,0,6
	.asciz "m_Exception"

LDIFF_SYM433=LTDIE_67_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM433
	.byte 2,35,16,6
	.asciz "m_stackTrace"

LDIFF_SYM434=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM434
	.byte 2,35,24,0,7
	.asciz "System_Runtime_ExceptionServices_ExceptionDispatchInfo"

LDIFF_SYM435=LTDIE_66 - Ldebug_info_start
	.long LDIFF_SYM435
LTDIE_66_POINTER:

	.byte 13
LDIFF_SYM436=LTDIE_66 - Ldebug_info_start
	.long LDIFF_SYM436
LTDIE_66_REFERENCE:

	.byte 14
LDIFF_SYM437=LTDIE_66 - Ldebug_info_start
	.long LDIFF_SYM437
LTDIE_64:

	.byte 5
	.asciz "System_Threading_Tasks_TaskExceptionHolder"

	.byte 48,16
LDIFF_SYM438=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM438
	.byte 2,35,0,6
	.asciz "m_task"

LDIFF_SYM439=LTDIE_37_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM439
	.byte 2,35,16,6
	.asciz "m_faultExceptions"

LDIFF_SYM440=LTDIE_65_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM440
	.byte 2,35,24,6
	.asciz "m_cancellationException"

LDIFF_SYM441=LTDIE_66_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM441
	.byte 2,35,32,6
	.asciz "m_isHandled"

LDIFF_SYM442=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM442
	.byte 2,35,40,0,7
	.asciz "System_Threading_Tasks_TaskExceptionHolder"

LDIFF_SYM443=LTDIE_64 - Ldebug_info_start
	.long LDIFF_SYM443
LTDIE_64_POINTER:

	.byte 13
LDIFF_SYM444=LTDIE_64 - Ldebug_info_start
	.long LDIFF_SYM444
LTDIE_64_REFERENCE:

	.byte 14
LDIFF_SYM445=LTDIE_64 - Ldebug_info_start
	.long LDIFF_SYM445
LTDIE_77:

	.byte 5
	.asciz "System_Threading_Tasks_Shared`1"

	.byte 40,16
LDIFF_SYM446=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM446
	.byte 2,35,0,6
	.asciz "Value"

LDIFF_SYM447=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM447
	.byte 2,35,16,0,7
	.asciz "System_Threading_Tasks_Shared`1"

LDIFF_SYM448=LTDIE_77 - Ldebug_info_start
	.long LDIFF_SYM448
LTDIE_77_POINTER:

	.byte 13
LDIFF_SYM449=LTDIE_77 - Ldebug_info_start
	.long LDIFF_SYM449
LTDIE_77_REFERENCE:

	.byte 14
LDIFF_SYM450=LTDIE_77 - Ldebug_info_start
	.long LDIFF_SYM450
LTDIE_78:

	.byte 5
	.asciz "System_Collections_Generic_List`1"

	.byte 32,16
LDIFF_SYM451=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM451
	.byte 2,35,0,6
	.asciz "_items"

LDIFF_SYM452=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM452
	.byte 2,35,16,6
	.asciz "_size"

LDIFF_SYM453=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM453
	.byte 2,35,24,6
	.asciz "_version"

LDIFF_SYM454=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM454
	.byte 2,35,28,0,7
	.asciz "System_Collections_Generic_List`1"

LDIFF_SYM455=LTDIE_78 - Ldebug_info_start
	.long LDIFF_SYM455
LTDIE_78_POINTER:

	.byte 13
LDIFF_SYM456=LTDIE_78 - Ldebug_info_start
	.long LDIFF_SYM456
LTDIE_78_REFERENCE:

	.byte 14
LDIFF_SYM457=LTDIE_78 - Ldebug_info_start
	.long LDIFF_SYM457
LTDIE_39:

	.byte 5
	.asciz "_ContingentProperties"

	.byte 72,16
LDIFF_SYM458=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM458
	.byte 2,35,0,6
	.asciz "m_capturedContext"

LDIFF_SYM459=LTDIE_40_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM459
	.byte 2,35,16,6
	.asciz "m_completionEvent"

LDIFF_SYM460=LTDIE_56_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM460
	.byte 2,35,24,6
	.asciz "m_exceptionsHolder"

LDIFF_SYM461=LTDIE_64_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM461
	.byte 2,35,32,6
	.asciz "m_cancellationToken"

LDIFF_SYM462=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM462
	.byte 2,35,40,6
	.asciz "m_cancellationRegistration"

LDIFF_SYM463=LTDIE_77_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM463
	.byte 2,35,48,6
	.asciz "m_internalCancellationRequested"

LDIFF_SYM464=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM464
	.byte 2,35,64,6
	.asciz "m_completionCountdown"

LDIFF_SYM465=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM465
	.byte 2,35,68,6
	.asciz "m_exceptionalChildren"

LDIFF_SYM466=LTDIE_78_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM466
	.byte 2,35,56,0,7
	.asciz "_ContingentProperties"

LDIFF_SYM467=LTDIE_39 - Ldebug_info_start
	.long LDIFF_SYM467
LTDIE_39_POINTER:

	.byte 13
LDIFF_SYM468=LTDIE_39 - Ldebug_info_start
	.long LDIFF_SYM468
LTDIE_39_REFERENCE:

	.byte 14
LDIFF_SYM469=LTDIE_39 - Ldebug_info_start
	.long LDIFF_SYM469
LTDIE_37:

	.byte 5
	.asciz "System_Threading_Tasks_Task"

	.byte 72,16
LDIFF_SYM470=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM470
	.byte 2,35,0,6
	.asciz "m_taskId"

LDIFF_SYM471=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM471
	.byte 2,35,64,6
	.asciz "m_action"

LDIFF_SYM472=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM472
	.byte 2,35,16,6
	.asciz "m_stateObject"

LDIFF_SYM473=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM473
	.byte 2,35,24,6
	.asciz "m_taskScheduler"

LDIFF_SYM474=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM474
	.byte 2,35,32,6
	.asciz "m_parent"

LDIFF_SYM475=LTDIE_37_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM475
	.byte 2,35,40,6
	.asciz "m_stateFlags"

LDIFF_SYM476=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM476
	.byte 2,35,68,6
	.asciz "m_continuationObject"

LDIFF_SYM477=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM477
	.byte 2,35,48,6
	.asciz "m_contingentProperties"

LDIFF_SYM478=LTDIE_39_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM478
	.byte 2,35,56,0,7
	.asciz "System_Threading_Tasks_Task"

LDIFF_SYM479=LTDIE_37 - Ldebug_info_start
	.long LDIFF_SYM479
LTDIE_37_POINTER:

	.byte 13
LDIFF_SYM480=LTDIE_37 - Ldebug_info_start
	.long LDIFF_SYM480
LTDIE_37_REFERENCE:

	.byte 14
LDIFF_SYM481=LTDIE_37 - Ldebug_info_start
	.long LDIFF_SYM481
LTDIE_81:

	.byte 5
	.asciz "_ResolveEventHolder"

	.byte 16,16
LDIFF_SYM482=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM482
	.byte 2,35,0,0,7
	.asciz "_ResolveEventHolder"

LDIFF_SYM483=LTDIE_81 - Ldebug_info_start
	.long LDIFF_SYM483
LTDIE_81_POINTER:

	.byte 13
LDIFF_SYM484=LTDIE_81 - Ldebug_info_start
	.long LDIFF_SYM484
LTDIE_81_REFERENCE:

	.byte 14
LDIFF_SYM485=LTDIE_81 - Ldebug_info_start
	.long LDIFF_SYM485
LTDIE_80:

	.byte 5
	.asciz "System_Reflection_Assembly"

	.byte 96,16
LDIFF_SYM486=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM486
	.byte 2,35,0,6
	.asciz "_mono_assembly"

LDIFF_SYM487=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM487
	.byte 2,35,16,6
	.asciz "resolve_event_holder"

LDIFF_SYM488=LTDIE_81_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM488
	.byte 2,35,24,6
	.asciz "_evidence"

LDIFF_SYM489=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM489
	.byte 2,35,32,6
	.asciz "_minimum"

LDIFF_SYM490=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM490
	.byte 2,35,40,6
	.asciz "_optional"

LDIFF_SYM491=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM491
	.byte 2,35,48,6
	.asciz "_refuse"

LDIFF_SYM492=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM492
	.byte 2,35,56,6
	.asciz "_granted"

LDIFF_SYM493=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM493
	.byte 2,35,64,6
	.asciz "_denied"

LDIFF_SYM494=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM494
	.byte 2,35,72,6
	.asciz "fromByteArray"

LDIFF_SYM495=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM495
	.byte 2,35,80,6
	.asciz "assemblyName"

LDIFF_SYM496=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM496
	.byte 2,35,88,0,7
	.asciz "System_Reflection_Assembly"

LDIFF_SYM497=LTDIE_80 - Ldebug_info_start
	.long LDIFF_SYM497
LTDIE_80_POINTER:

	.byte 13
LDIFF_SYM498=LTDIE_80 - Ldebug_info_start
	.long LDIFF_SYM498
LTDIE_80_REFERENCE:

	.byte 14
LDIFF_SYM499=LTDIE_80 - Ldebug_info_start
	.long LDIFF_SYM499
LTDIE_79:

	.byte 5
	.asciz "NUnit_Framework_Internal_NUnitLiteTestAssemblyBuilder"

	.byte 24,16
LDIFF_SYM500=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM500
	.byte 2,35,0,6
	.asciz "assembly"

LDIFF_SYM501=LTDIE_80_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM501
	.byte 2,35,16,0,7
	.asciz "NUnit_Framework_Internal_NUnitLiteTestAssemblyBuilder"

LDIFF_SYM502=LTDIE_79 - Ldebug_info_start
	.long LDIFF_SYM502
LTDIE_79_POINTER:

	.byte 13
LDIFF_SYM503=LTDIE_79 - Ldebug_info_start
	.long LDIFF_SYM503
LTDIE_79_REFERENCE:

	.byte 14
LDIFF_SYM504=LTDIE_79 - Ldebug_info_start
	.long LDIFF_SYM504
LTDIE_83:

	.byte 5
	.asciz "_KeyCollection"

	.byte 24,16
LDIFF_SYM505=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM505
	.byte 2,35,0,6
	.asciz "dictionary"

LDIFF_SYM506=LTDIE_82_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM506
	.byte 2,35,16,0,7
	.asciz "_KeyCollection"

LDIFF_SYM507=LTDIE_83 - Ldebug_info_start
	.long LDIFF_SYM507
LTDIE_83_POINTER:

	.byte 13
LDIFF_SYM508=LTDIE_83 - Ldebug_info_start
	.long LDIFF_SYM508
LTDIE_83_REFERENCE:

	.byte 14
LDIFF_SYM509=LTDIE_83 - Ldebug_info_start
	.long LDIFF_SYM509
LTDIE_84:

	.byte 5
	.asciz "_ValueCollection"

	.byte 24,16
LDIFF_SYM510=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM510
	.byte 2,35,0,6
	.asciz "dictionary"

LDIFF_SYM511=LTDIE_82_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM511
	.byte 2,35,16,0,7
	.asciz "_ValueCollection"

LDIFF_SYM512=LTDIE_84 - Ldebug_info_start
	.long LDIFF_SYM512
LTDIE_84_POINTER:

	.byte 13
LDIFF_SYM513=LTDIE_84 - Ldebug_info_start
	.long LDIFF_SYM513
LTDIE_84_REFERENCE:

	.byte 14
LDIFF_SYM514=LTDIE_84 - Ldebug_info_start
	.long LDIFF_SYM514
LTDIE_82:

	.byte 5
	.asciz "System_Collections_Generic_Dictionary`2"

	.byte 72,16
LDIFF_SYM515=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM515
	.byte 2,35,0,6
	.asciz "buckets"

LDIFF_SYM516=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM516
	.byte 2,35,16,6
	.asciz "entries"

LDIFF_SYM517=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM517
	.byte 2,35,24,6
	.asciz "count"

LDIFF_SYM518=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM518
	.byte 2,35,56,6
	.asciz "version"

LDIFF_SYM519=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM519
	.byte 2,35,60,6
	.asciz "freeList"

LDIFF_SYM520=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM520
	.byte 2,35,64,6
	.asciz "freeCount"

LDIFF_SYM521=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM521
	.byte 2,35,68,6
	.asciz "comparer"

LDIFF_SYM522=LTDIE_20_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM522
	.byte 2,35,32,6
	.asciz "keys"

LDIFF_SYM523=LTDIE_83_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM523
	.byte 2,35,40,6
	.asciz "values"

LDIFF_SYM524=LTDIE_84_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM524
	.byte 2,35,48,0,7
	.asciz "System_Collections_Generic_Dictionary`2"

LDIFF_SYM525=LTDIE_82 - Ldebug_info_start
	.long LDIFF_SYM525
LTDIE_82_POINTER:

	.byte 13
LDIFF_SYM526=LTDIE_82 - Ldebug_info_start
	.long LDIFF_SYM526
LTDIE_82_REFERENCE:

	.byte 14
LDIFF_SYM527=LTDIE_82 - Ldebug_info_start
	.long LDIFF_SYM527
LTDIE_11:

	.byte 5
	.asciz "MonoTouch_NUnit_UI_BaseTouchRunner"

	.byte 112,16
LDIFF_SYM528=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM528
	.byte 2,35,0,6
	.asciz "suite"

LDIFF_SYM529=LTDIE_12_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM529
	.byte 2,35,16,6
	.asciz "filter"

LDIFF_SYM530=LTDIE_27_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM530
	.byte 2,35,24,6
	.asciz "connection_failure"

LDIFF_SYM531=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM531
	.byte 2,35,88,6
	.asciz "<PassedCount>k__BackingField"

LDIFF_SYM532=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM532
	.byte 2,35,92,6
	.asciz "<FailedCount>k__BackingField"

LDIFF_SYM533=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM533
	.byte 2,35,96,6
	.asciz "<IgnoredCount>k__BackingField"

LDIFF_SYM534=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM534
	.byte 2,35,100,6
	.asciz "<InconclusiveCount>k__BackingField"

LDIFF_SYM535=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM535
	.byte 2,35,104,6
	.asciz "assemblies"

LDIFF_SYM536=LTDIE_28_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM536
	.byte 2,35,32,6
	.asciz "fixtures"

LDIFF_SYM537=LTDIE_29_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM537
	.byte 2,35,40,6
	.asciz "running"

LDIFF_SYM538=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM538
	.byte 2,35,108,6
	.asciz "<Result>k__BackingField"

LDIFF_SYM539=LTDIE_30_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM539
	.byte 2,35,48,6
	.asciz "<Writer>k__BackingField"

LDIFF_SYM540=LTDIE_34_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM540
	.byte 2,35,56,6
	.asciz "<WriterFinishedTask>k__BackingField"

LDIFF_SYM541=LTDIE_37_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM541
	.byte 2,35,64,6
	.asciz "builder"

LDIFF_SYM542=LTDIE_79_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM542
	.byte 2,35,72,6
	.asciz "empty"

LDIFF_SYM543=LTDIE_82_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM543
	.byte 2,35,80,0,7
	.asciz "MonoTouch_NUnit_UI_BaseTouchRunner"

LDIFF_SYM544=LTDIE_11 - Ldebug_info_start
	.long LDIFF_SYM544
LTDIE_11_POINTER:

	.byte 13
LDIFF_SYM545=LTDIE_11 - Ldebug_info_start
	.long LDIFF_SYM545
LTDIE_11_REFERENCE:

	.byte 14
LDIFF_SYM546=LTDIE_11 - Ldebug_info_start
	.long LDIFF_SYM546
LTDIE_86:

	.byte 17
	.asciz "System_Collections_Generic_IEqualityComparer`1"

	.byte 16,7
	.asciz "System_Collections_Generic_IEqualityComparer`1"

LDIFF_SYM547=LTDIE_86 - Ldebug_info_start
	.long LDIFF_SYM547
LTDIE_86_POINTER:

	.byte 13
LDIFF_SYM548=LTDIE_86 - Ldebug_info_start
	.long LDIFF_SYM548
LTDIE_86_REFERENCE:

	.byte 14
LDIFF_SYM549=LTDIE_86 - Ldebug_info_start
	.long LDIFF_SYM549
LTDIE_87:

	.byte 5
	.asciz "_KeyCollection"

	.byte 24,16
LDIFF_SYM550=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM550
	.byte 2,35,0,6
	.asciz "dictionary"

LDIFF_SYM551=LTDIE_85_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM551
	.byte 2,35,16,0,7
	.asciz "_KeyCollection"

LDIFF_SYM552=LTDIE_87 - Ldebug_info_start
	.long LDIFF_SYM552
LTDIE_87_POINTER:

	.byte 13
LDIFF_SYM553=LTDIE_87 - Ldebug_info_start
	.long LDIFF_SYM553
LTDIE_87_REFERENCE:

	.byte 14
LDIFF_SYM554=LTDIE_87 - Ldebug_info_start
	.long LDIFF_SYM554
LTDIE_88:

	.byte 5
	.asciz "_ValueCollection"

	.byte 24,16
LDIFF_SYM555=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM555
	.byte 2,35,0,6
	.asciz "dictionary"

LDIFF_SYM556=LTDIE_85_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM556
	.byte 2,35,16,0,7
	.asciz "_ValueCollection"

LDIFF_SYM557=LTDIE_88 - Ldebug_info_start
	.long LDIFF_SYM557
LTDIE_88_POINTER:

	.byte 13
LDIFF_SYM558=LTDIE_88 - Ldebug_info_start
	.long LDIFF_SYM558
LTDIE_88_REFERENCE:

	.byte 14
LDIFF_SYM559=LTDIE_88 - Ldebug_info_start
	.long LDIFF_SYM559
LTDIE_85:

	.byte 5
	.asciz "System_Collections_Generic_Dictionary`2"

	.byte 72,16
LDIFF_SYM560=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM560
	.byte 2,35,0,6
	.asciz "buckets"

LDIFF_SYM561=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM561
	.byte 2,35,16,6
	.asciz "entries"

LDIFF_SYM562=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM562
	.byte 2,35,24,6
	.asciz "count"

LDIFF_SYM563=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM563
	.byte 2,35,56,6
	.asciz "version"

LDIFF_SYM564=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM564
	.byte 2,35,60,6
	.asciz "freeList"

LDIFF_SYM565=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM565
	.byte 2,35,64,6
	.asciz "freeCount"

LDIFF_SYM566=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM566
	.byte 2,35,68,6
	.asciz "comparer"

LDIFF_SYM567=LTDIE_86_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM567
	.byte 2,35,32,6
	.asciz "keys"

LDIFF_SYM568=LTDIE_87_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM568
	.byte 2,35,40,6
	.asciz "values"

LDIFF_SYM569=LTDIE_88_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM569
	.byte 2,35,48,0,7
	.asciz "System_Collections_Generic_Dictionary`2"

LDIFF_SYM570=LTDIE_85 - Ldebug_info_start
	.long LDIFF_SYM570
LTDIE_85_POINTER:

	.byte 13
LDIFF_SYM571=LTDIE_85 - Ldebug_info_start
	.long LDIFF_SYM571
LTDIE_85_REFERENCE:

	.byte 14
LDIFF_SYM572=LTDIE_85 - Ldebug_info_start
	.long LDIFF_SYM572
LTDIE_90:

	.byte 5
	.asciz "_KeyCollection"

	.byte 24,16
LDIFF_SYM573=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM573
	.byte 2,35,0,6
	.asciz "dictionary"

LDIFF_SYM574=LTDIE_89_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM574
	.byte 2,35,16,0,7
	.asciz "_KeyCollection"

LDIFF_SYM575=LTDIE_90 - Ldebug_info_start
	.long LDIFF_SYM575
LTDIE_90_POINTER:

	.byte 13
LDIFF_SYM576=LTDIE_90 - Ldebug_info_start
	.long LDIFF_SYM576
LTDIE_90_REFERENCE:

	.byte 14
LDIFF_SYM577=LTDIE_90 - Ldebug_info_start
	.long LDIFF_SYM577
LTDIE_91:

	.byte 5
	.asciz "_ValueCollection"

	.byte 24,16
LDIFF_SYM578=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM578
	.byte 2,35,0,6
	.asciz "dictionary"

LDIFF_SYM579=LTDIE_89_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM579
	.byte 2,35,16,0,7
	.asciz "_ValueCollection"

LDIFF_SYM580=LTDIE_91 - Ldebug_info_start
	.long LDIFF_SYM580
LTDIE_91_POINTER:

	.byte 13
LDIFF_SYM581=LTDIE_91 - Ldebug_info_start
	.long LDIFF_SYM581
LTDIE_91_REFERENCE:

	.byte 14
LDIFF_SYM582=LTDIE_91 - Ldebug_info_start
	.long LDIFF_SYM582
LTDIE_89:

	.byte 5
	.asciz "System_Collections_Generic_Dictionary`2"

	.byte 72,16
LDIFF_SYM583=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM583
	.byte 2,35,0,6
	.asciz "buckets"

LDIFF_SYM584=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM584
	.byte 2,35,16,6
	.asciz "entries"

LDIFF_SYM585=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM585
	.byte 2,35,24,6
	.asciz "count"

LDIFF_SYM586=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM586
	.byte 2,35,56,6
	.asciz "version"

LDIFF_SYM587=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM587
	.byte 2,35,60,6
	.asciz "freeList"

LDIFF_SYM588=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM588
	.byte 2,35,64,6
	.asciz "freeCount"

LDIFF_SYM589=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM589
	.byte 2,35,68,6
	.asciz "comparer"

LDIFF_SYM590=LTDIE_86_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM590
	.byte 2,35,32,6
	.asciz "keys"

LDIFF_SYM591=LTDIE_90_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM591
	.byte 2,35,40,6
	.asciz "values"

LDIFF_SYM592=LTDIE_91_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM592
	.byte 2,35,48,0,7
	.asciz "System_Collections_Generic_Dictionary`2"

LDIFF_SYM593=LTDIE_89 - Ldebug_info_start
	.long LDIFF_SYM593
LTDIE_89_POINTER:

	.byte 13
LDIFF_SYM594=LTDIE_89 - Ldebug_info_start
	.long LDIFF_SYM594
LTDIE_89_REFERENCE:

	.byte 14
LDIFF_SYM595=LTDIE_89 - Ldebug_info_start
	.long LDIFF_SYM595
LTDIE_93:

	.byte 17
	.asciz "System_Collections_Generic_IEqualityComparer`1"

	.byte 16,7
	.asciz "System_Collections_Generic_IEqualityComparer`1"

LDIFF_SYM596=LTDIE_93 - Ldebug_info_start
	.long LDIFF_SYM596
LTDIE_93_POINTER:

	.byte 13
LDIFF_SYM597=LTDIE_93 - Ldebug_info_start
	.long LDIFF_SYM597
LTDIE_93_REFERENCE:

	.byte 14
LDIFF_SYM598=LTDIE_93 - Ldebug_info_start
	.long LDIFF_SYM598
LTDIE_94:

	.byte 5
	.asciz "_KeyCollection"

	.byte 24,16
LDIFF_SYM599=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM599
	.byte 2,35,0,6
	.asciz "dictionary"

LDIFF_SYM600=LTDIE_92_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM600
	.byte 2,35,16,0,7
	.asciz "_KeyCollection"

LDIFF_SYM601=LTDIE_94 - Ldebug_info_start
	.long LDIFF_SYM601
LTDIE_94_POINTER:

	.byte 13
LDIFF_SYM602=LTDIE_94 - Ldebug_info_start
	.long LDIFF_SYM602
LTDIE_94_REFERENCE:

	.byte 14
LDIFF_SYM603=LTDIE_94 - Ldebug_info_start
	.long LDIFF_SYM603
LTDIE_95:

	.byte 5
	.asciz "_ValueCollection"

	.byte 24,16
LDIFF_SYM604=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM604
	.byte 2,35,0,6
	.asciz "dictionary"

LDIFF_SYM605=LTDIE_92_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM605
	.byte 2,35,16,0,7
	.asciz "_ValueCollection"

LDIFF_SYM606=LTDIE_95 - Ldebug_info_start
	.long LDIFF_SYM606
LTDIE_95_POINTER:

	.byte 13
LDIFF_SYM607=LTDIE_95 - Ldebug_info_start
	.long LDIFF_SYM607
LTDIE_95_REFERENCE:

	.byte 14
LDIFF_SYM608=LTDIE_95 - Ldebug_info_start
	.long LDIFF_SYM608
LTDIE_92:

	.byte 5
	.asciz "System_Collections_Generic_Dictionary`2"

	.byte 72,16
LDIFF_SYM609=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM609
	.byte 2,35,0,6
	.asciz "buckets"

LDIFF_SYM610=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM610
	.byte 2,35,16,6
	.asciz "entries"

LDIFF_SYM611=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM611
	.byte 2,35,24,6
	.asciz "count"

LDIFF_SYM612=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM612
	.byte 2,35,56,6
	.asciz "version"

LDIFF_SYM613=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM613
	.byte 2,35,60,6
	.asciz "freeList"

LDIFF_SYM614=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM614
	.byte 2,35,64,6
	.asciz "freeCount"

LDIFF_SYM615=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM615
	.byte 2,35,68,6
	.asciz "comparer"

LDIFF_SYM616=LTDIE_93_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM616
	.byte 2,35,32,6
	.asciz "keys"

LDIFF_SYM617=LTDIE_94_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM617
	.byte 2,35,40,6
	.asciz "values"

LDIFF_SYM618=LTDIE_95_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM618
	.byte 2,35,48,0,7
	.asciz "System_Collections_Generic_Dictionary`2"

LDIFF_SYM619=LTDIE_92 - Ldebug_info_start
	.long LDIFF_SYM619
LTDIE_92_POINTER:

	.byte 13
LDIFF_SYM620=LTDIE_92 - Ldebug_info_start
	.long LDIFF_SYM620
LTDIE_92_REFERENCE:

	.byte 14
LDIFF_SYM621=LTDIE_92 - Ldebug_info_start
	.long LDIFF_SYM621
LTDIE_10:

	.byte 5
	.asciz "MonoTouch_NUnit_UI_TouchRunner"

	.byte 144,1,16
LDIFF_SYM622=LTDIE_11 - Ldebug_info_start
	.long LDIFF_SYM622
	.byte 2,35,0,6
	.asciz "window"

LDIFF_SYM623=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM623
	.byte 2,35,112,6
	.asciz "suites_dvc"

LDIFF_SYM624=LTDIE_85_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM624
	.byte 2,35,120,6
	.asciz "suite_elements"

LDIFF_SYM625=LTDIE_89_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM625
	.byte 3,35,128,1,6
	.asciz "case_elements"

LDIFF_SYM626=LTDIE_92_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM626
	.byte 3,35,136,1,0,7
	.asciz "MonoTouch_NUnit_UI_TouchRunner"

LDIFF_SYM627=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM627
LTDIE_10_POINTER:

	.byte 13
LDIFF_SYM628=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM628
LTDIE_10_REFERENCE:

	.byte 14
LDIFF_SYM629=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM629
LTDIE_3:

	.byte 5
	.asciz "PorpoiseUnitTest_UnitTestAppDelegate"

	.byte 56,16
LDIFF_SYM630=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM630
	.byte 2,35,0,6
	.asciz "window"

LDIFF_SYM631=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM631
	.byte 2,35,40,6
	.asciz "runner"

LDIFF_SYM632=LTDIE_10_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM632
	.byte 2,35,48,0,7
	.asciz "PorpoiseUnitTest_UnitTestAppDelegate"

LDIFF_SYM633=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM633
LTDIE_3_POINTER:

	.byte 13
LDIFF_SYM634=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM634
LTDIE_3_REFERENCE:

	.byte 14
LDIFF_SYM635=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM635
LTDIE_96:

	.byte 5
	.asciz "UIKit_UIApplication"

	.byte 40,16
LDIFF_SYM636=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM636
	.byte 2,35,0,0,7
	.asciz "UIKit_UIApplication"

LDIFF_SYM637=LTDIE_96 - Ldebug_info_start
	.long LDIFF_SYM637
LTDIE_96_POINTER:

	.byte 13
LDIFF_SYM638=LTDIE_96 - Ldebug_info_start
	.long LDIFF_SYM638
LTDIE_96_REFERENCE:

	.byte 14
LDIFF_SYM639=LTDIE_96 - Ldebug_info_start
	.long LDIFF_SYM639
LTDIE_97:

	.byte 5
	.asciz "Foundation_NSDictionary"

	.byte 40,16
LDIFF_SYM640=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM640
	.byte 2,35,0,0,7
	.asciz "Foundation_NSDictionary"

LDIFF_SYM641=LTDIE_97 - Ldebug_info_start
	.long LDIFF_SYM641
LTDIE_97_POINTER:

	.byte 13
LDIFF_SYM642=LTDIE_97 - Ldebug_info_start
	.long LDIFF_SYM642
LTDIE_97_REFERENCE:

	.byte 14
LDIFF_SYM643=LTDIE_97 - Ldebug_info_start
	.long LDIFF_SYM643
	.byte 2
	.asciz "PorpoiseUnitTest.UnitTestAppDelegate:FinishedLaunching"
	.asciz "PorpoiseUnitTest_UnitTestAppDelegate_FinishedLaunching_UIKit_UIApplication_Foundation_NSDictionary"

	.byte 3,29
	.quad PorpoiseUnitTest_UnitTestAppDelegate_FinishedLaunching_UIKit_UIApplication_Foundation_NSDictionary
	.quad Lme_6

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM644=LTDIE_3_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM644
	.byte 1,106,3
	.asciz "app"

LDIFF_SYM645=LTDIE_96_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM645
	.byte 2,141,32,3
	.asciz "options"

LDIFF_SYM646=LTDIE_97_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM646
	.byte 2,141,40,11
	.asciz "V_0"

LDIFF_SYM647=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM647
	.byte 1,105,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM648=Lfde6_end - Lfde6_start
	.long LDIFF_SYM648
Lfde6_start:

	.long 0
	.align 3
	.quad PorpoiseUnitTest_UnitTestAppDelegate_FinishedLaunching_UIKit_UIApplication_Foundation_NSDictionary

LDIFF_SYM649=Lme_6 - PorpoiseUnitTest_UnitTestAppDelegate_FinishedLaunching_UIKit_UIApplication_Foundation_NSDictionary
	.long LDIFF_SYM649
	.long 0
	.byte 12,31,0,68,14,208,1,157,26,158,25,68,13,29,68,153,24,154,23
	.align 3
Lfde6_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PorpoiseUnitTest.UnitTestAppDelegate:.ctor"
	.asciz "PorpoiseUnitTest_UnitTestAppDelegate__ctor"

	.byte 0,0
	.quad PorpoiseUnitTest_UnitTestAppDelegate__ctor
	.quad Lme_7

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM650=LTDIE_3_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM650
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM651=Lfde7_end - Lfde7_start
	.long LDIFF_SYM651
Lfde7_start:

	.long 0
	.align 3
	.quad PorpoiseUnitTest_UnitTestAppDelegate__ctor

LDIFF_SYM652=Lme_7 - PorpoiseUnitTest_UnitTestAppDelegate__ctor
	.long LDIFF_SYM652
	.long 0
	.byte 12,31,0,68,14,48,157,6,158,5,68,13,29
	.align 3
Lfde7_end:

.section __DWARF, __debug_info,regular,debug

	.byte 0
Ldebug_info_end:
.text
	.align 3
mem_end:
