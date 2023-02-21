//
// Copyright (c) .NET Foundation and Contributors
// See LICENSE file in the project root for full license information.
//

namespace nanoFramework.Tools.MetadataProcessor
{
    internal partial class SkeletonTemplates
    {
        internal const string AssemblyHeaderTemplate =
@"
{{#if IsCoreLib}}
//-----------------------------------------------------------------------------{{#newline}}
//{{#newline}}
//                   ** WARNING! ** {{#newline}}
//    This file was generated automatically by a tool.{{#newline}}
//    Re-running the tool will overwrite this file.{{#newline}}
//    You should copy this file to a custom location{{#newline}}
//    before adding any customization in the copy to{{#newline}}
//    prevent loss of your changes when the tool is{{#newline}}
//    re-run.{{#newline}}
//{{#newline}}
//-----------------------------------------------------------------------------{{#newline}}
{{#else}}
//-----------------------------------------------------------------------------{{#newline}}
//{{#newline}}
//    ** DO NOT EDIT THIS FILE! **{{#newline}}
//    This file was generated by a tool{{#newline}}
//    re-running the tool will overwrite this file.{{#newline}}
//{{#newline}}
//-----------------------------------------------------------------------------{{#newline}}
{{/if}}
{{#newline}}

#ifndef {{ShortNameUpper}}_H{{#newline}}
#define {{ShortNameUpper}}_H{{#newline}}
{{#newline}}

#include <nanoCLR_Interop.h>{{#newline}}
#include <nanoCLR_Runtime.h>{{#newline}}
#include <nanoPackStruct.h>{{#newline}}
{{#if IsCoreLib}}
#include <corlib_native.h>{{#newline}}
{{#else}}
{{/if}}
{{#newline}}

{{#each Enums}}
typedef enum __nfpack {{EnumName}}{{#newline}}
{
{{#newline}}
{{#each Items}}
    {{Name}} = {{Value}},{{#newline}}
{{/each}}

} {{EnumName}};{{#newline}}
{{#newline}}
{{/each}}

{{#each Classes}}
struct Library_{{AssemblyName}}_{{Name}}{{#newline}}
{{{#newline}}

{{#each StaticFields}}
    static const int FIELD_STATIC__{{Name}} = {{ReferenceIndex}};{{#newline}}
{{/each}}
{{#if StaticFields}}{{#newline}}{{/if}}

{{#each InstanceFields}}
{{#if FieldWarning}}{{FieldWarning}}{{/if}}
    static const int FIELD__{{Name}} = {{ReferenceIndex}};{{#newline}}
{{/each}}
{{#if InstanceFields}}{{#newline}}{{/if}}

{{#each Methods}}
    NANOCLR_NATIVE_DECLARE({{Declaration}});{{#newline}}
{{/each}}
{{#if Methods}}{{#newline}}{{/if}}

    //--//{{#newline}}
};{{#newline}}
{{#newline}}
{{/each}}
extern const CLR_RT_NativeAssemblyData g_CLR_AssemblyNative_{{Name}};{{#newline}}
{{#newline}}
#endif // {{ShortNameUpper}}_H{{#newline}}
";

        internal const string AssemblyLookupTemplate =
@"
{{#if IsCoreLib}}
{{#else}}
//-----------------------------------------------------------------------------{{#newline}}
//{{#newline}}
//    ** DO NOT EDIT THIS FILE! **{{#newline}}
//    This file was generated by a tool{{#newline}}
//    re-running the tool will overwrite this file.{{#newline}}
//{{#newline}}
//-----------------------------------------------------------------------------{{#newline}}
{{#newline}}
{{/if}}

#include ""{{HeaderFileName}}.h""{{#newline}}
{{#newline}}

// clang-format off{{#newline}}
{{#newline}}

static const CLR_RT_MethodHandler method_lookup[] ={{#newline}}
{{{#newline}}
{{#each LookupTable}}
    {{Declaration}},{{#newline}}
{{/each}}
};{{#newline}}
{{#newline}}

const CLR_RT_NativeAssemblyData g_CLR_AssemblyNative_{{Name}} ={{#newline}}
{{{#newline}}
    ""{{AssemblyName}}"",{{#newline}}
    {{NativeCRC32}},{{#newline}}
    method_lookup,{{#newline}}
    { {{NativeVersion.Major}}, {{NativeVersion.Minor}}, {{NativeVersion.Build}}, {{NativeVersion.Revision}} }{{#newline}}
};{{#newline}}

{{#newline}}
// clang-format on{{#newline}}

";

        internal const string ClassWithoutInteropStubTemplate =
@"//-----------------------------------------------------------------------------
//
//                   ** WARNING! ** 
//    This file was generated automatically by a tool.
//    Re-running the tool will overwrite this file.
//    You should copy this file to a custom location
//    before adding any customization in the copy to
//    prevent loss of your changes when the tool is
//    re-run.
//
//-----------------------------------------------------------------------------

#include ""{{HeaderFileName}}.h""

{{#each Functions}}
HRESULT {{Declaration}}( CLR_RT_StackFrame &stack )
{
    NANOCLR_HEADER();

    NANOCLR_SET_AND_LEAVE(stack.NotImplementedStub());

    NANOCLR_NOCLEANUP();
}
{{/each}}";

        internal const string ClassStubTemplate =
@"//-----------------------------------------------------------------------------
//
//                   ** WARNING! ** 
//    This file was generated automatically by a tool.
//    Re-running the tool will overwrite this file.
//    You should copy this file to a custom location
//    before adding any customization in the copy to
//    prevent loss of your changes when the tool is
//    re-run.
//
//-----------------------------------------------------------------------------

#include ""{{HeaderFileName}}.h""
#include ""{{HeaderFileName}}_{{ClassHeaderFileName}}.h""

using namespace {{RootNamespace}}::{{ProjectName}};

{{#each Functions}}
{{ReturnType}} {{ClassName}}::{{DeclarationForUserCode}}
{
{{#each ParameterDeclaration}}
    (void){{Name}};{{/each}}
    (void)hr;
{{#if HasReturnType}}    {{ReturnType}} retValue = 0;{{/if}}

    ////////////////////////////////
    // implementation starts here //


    // implementation ends here   //
    ////////////////////////////////

{{#if HasReturnType}}    return retValue;{{/if}}
}
{{/each}}";

        internal const string ClassHeaderTemplate =
@"//-----------------------------------------------------------------------------
//
//                   ** WARNING! ** 
//    This file was generated automatically by a tool.
//    Re-running the tool will overwrite this file.
//    You should copy this file to a custom location
//    before adding any customization in the copy to
//    prevent loss of your changes when the tool is
//    re-run.
//
//-----------------------------------------------------------------------------

#ifndef {{ShortNameUpper}}_H
#define {{ShortNameUpper}}_H

namespace {{RootNamespace}}
{
    namespace {{ProjectName}}
    {
        struct {{ClassName}}
        {
            // Helper Functions to access fields of managed object
            // Declaration of stubs. These functions are implemented by Interop code developers
{{#each Functions}}
            static {{ReturnType}} {{DeclarationForUserCode}};
{{/each}}
        };
    }
}

#endif // {{ShortNameUpper}}_H
";

        internal const string ClassMarshallingCodeTemplate =
@"//-----------------------------------------------------------------------------
//
//    ** DO NOT EDIT THIS FILE! **
//    This file was generated by a tool
//    re-running the tool will overwrite this file.
//
//-----------------------------------------------------------------------------

#include ""{{HeaderFileName}}.h""
#include ""{{HeaderFileName}}_{{ClassHeaderFileName}}.h""

using namespace {{RootNamespace}}::{{ProjectName}};

{{#each Functions}}
HRESULT {{Declaration}}( CLR_RT_StackFrame& stack )
{
    NANOCLR_HEADER(); hr = S_OK;
    {
{{#each ParameterDeclaration}}
        {{Declaration}}
        NANOCLR_CHECK_HRESULT( {{MarshallingDeclaration}} );
{{/each}}
        {{#if HasReturnType}}{{ReturnType}} retValue = {{/if}}{{ClassName}}::{{CallFromMarshalling}};
        NANOCLR_CHECK_HRESULT( hr );
{{#if HasReturnType}}        SetResult_{{MarshallingReturnType}}( stack, retValue );{{/if}}
    }
    NANOCLR_NOCLEANUP();
}
{{/each}}";

        internal const string CMakeModuleTemplate =
@"#
# Copyright (c) .NET Foundation and Contributors
# See LICENSE file in the project root for full license information.
#

{{#if IsInterop}}########################################################################################
# make sure that a valid path is set bellow                                            #
# this is an Interop module so this file should be placed in the CMakes module folder  #
# usually CMake\Modules                                                                #
########################################################################################

# native code directory
set(BASE_PATH_FOR_THIS_MODULE ${PROJECT_SOURCE_DIR}/InteropAssemblies/{{AssemblyName}})
{{#else}}# native code directory
set(BASE_PATH_FOR_THIS_MODULE ${BASE_PATH_FOR_CLASS_LIBRARIES_MODULES}/{{AssemblyName}})
{{/if}}

# set include directories
list(APPEND {{AssemblyName}}_INCLUDE_DIRS ${PROJECT_SOURCE_DIR}/src/CLR/Core)
list(APPEND {{AssemblyName}}_INCLUDE_DIRS ${PROJECT_SOURCE_DIR}/src/CLR/Include)
list(APPEND {{AssemblyName}}_INCLUDE_DIRS ${PROJECT_SOURCE_DIR}/src/HAL/Include)
list(APPEND {{AssemblyName}}_INCLUDE_DIRS ${PROJECT_SOURCE_DIR}/src/PAL/Include)
list(APPEND {{AssemblyName}}_INCLUDE_DIRS ${BASE_PATH_FOR_THIS_MODULE})
{{#if IsInterop}}{{#else}}list(APPEND {{AssemblyName}}_INCLUDE_DIRS ${PROJECT_SOURCE_DIR}/src/{{AssemblyName}}){{/if}}

# source files
set({{AssemblyName}}_SRCS

    {{ProjectName}}.cpp
{{#if IsInterop}}
{{#each ClassesWithStubs}}
    {{HeaderFileName}}_{{Name}}_mshl.cpp
    {{HeaderFileName}}_{{Name}}.cpp{{/each}}
{{#else}}
{{#each ClassesWithStubs}}
    {{HeaderFileName}}_{{Name}}.cpp{{/each}}
{{/if}}
)

foreach(SRC_FILE ${{{AssemblyName}}_SRCS})

    set({{AssemblyName}}_SRC_FILE SRC_FILE-NOTFOUND)

    find_file({{AssemblyName}}_SRC_FILE ${SRC_FILE}
        PATHS
	        ${BASE_PATH_FOR_THIS_MODULE}
	        ${TARGET_BASE_LOCATION}
            ${PROJECT_SOURCE_DIR}/src/{{AssemblyName}}

	    CMAKE_FIND_ROOT_PATH_BOTH
    )

    if (BUILD_VERBOSE)
        message(""${SRC_FILE} >> ${{{AssemblyName}}_SRC_FILE}"")
    endif()

    list(APPEND {{AssemblyName}}_SOURCES ${{{AssemblyName}}_SRC_FILE})

endforeach()

include(FindPackageHandleStandardArgs)

FIND_PACKAGE_HANDLE_STANDARD_ARGS({{AssemblyName}} DEFAULT_MSG {{AssemblyName}}_INCLUDE_DIRS {{AssemblyName}}_SOURCES)
";
    }
}
