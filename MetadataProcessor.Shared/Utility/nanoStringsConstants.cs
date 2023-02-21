﻿//
// Copyright (c) .NET Foundation and Contributors
// Original work from Oleg Rakhmatulin.
// See LICENSE file in the project root for full license information.
//

using System;
using System.Collections.Generic;
using System.Linq;

namespace nanoFramework.Tools.MetadataProcessor
{
    /// <summary>
    /// Helper class for storing list of 'predefined' string constants which encoded in
    /// .NET nanoFramework assembly metadata using special notation (highest possible values).
    /// </summary>
    internal static class nanoStringsConstants
    {
        /// <summary>
        /// Gets string reference identifier for passed string from constants table.
        /// </summary>
        /// <param name="value">String value for lookup.</param>
        /// <param name="index">String reference identifier.</param>
        /// <returns>Returns <c>true</c> if string found in constants table, <c>false</c> otherwise.</returns>
        public static bool TryGetStringIndex(
            string value,
            out ushort index)
        {
            return _idsByStrings.TryGetValue(value, out index);
        }

        /// <summary>
        /// Try to get a string value from the string constant table providing the index.
        /// </summary>
        /// <param name="index">String index in table.</param>
        /// <returns>The string value or a null if the index doesn't exist.</returns>
        public static string TryGetString(ushort index)
        {
            // try to get string from id table
            return _idsByStrings.FirstOrDefault(s => s.Value == index).Key;
        }

        private static readonly IDictionary<string, ushort> _idsByStrings = new[]
        {
             /* 0000 */ ".cctor",
             /* 0001 */ ".ctor",
             /* 0002 */ "Abort",
             /* 0003 */ "Abs",
             /* 0004 */ "AccessedThroughPropertyAttribute",
             /* 0005 */ "Acos",
             /* 0006 */ "Add",
             /* 0007 */ "AddDays",
             /* 0008 */ "AddHours",
             /* 0009 */ "AddMilliseconds",
             /* 000A */ "AddMinutes",
             /* 000B */ "AddSeconds",
             /* 000C */ "AddTicks",
             /* 000D */ "AnyPendingFinalizers",
             /* 000E */ "AppDomain",
             /* 000F */ "AppDomainUnloadedException",
             /* 0010 */ "Append",
             /* 0011 */ "AppendHelper",
             /* 0012 */ "AppendLine",
             /* 0013 */ "AppendTrailingZeros",
             /* 0014 */ "ApplicationException",
             /* 0015 */ "ArgumentException",
             /* 0016 */ "ArgumentNullException",
             /* 0017 */ "ArgumentOutOfRangeException",
             /* 0018 */ "Arguments",
             /* 0019 */ "Array",
             /* 001A */ "ArrayList",
             /* 001B */ "ArraySize",
             /* 001C */ "Asin",
             /* 001D */ "Assembly",
             /* 001E */ "AssemblyInfo",
             /* 001F */ "AssemblyMemoryInfo",
             /* 0020 */ "AssemblyName",
             /* 0021 */ "AssemblyNameFlags",
             /* 0022 */ "AssemblyRef",
             /* 0023 */ "AssemblyRefElements",
             /* 0024 */ "Assert",
             /* 0025 */ "AsyncCallback",
             /* 0026 */ "Atan",
             /* 0027 */ "Atan2",
             /* 0028 */ "Attribute",
             /* 0029 */ "Attributes",
             /* 002A */ "AttributesElements",
             /* 002B */ "AutoResetEvent",
             /* 002C */ "Backlight",
             /* 002D */ "BaseEvent",
             /* 002E */ "BeginInvoke",
             /* 002F */ "Bias",
             /* 0030 */ "BinarySearch",
             /* 0031 */ "Binder",
             /* 0032 */ "BindingFlags",
             /* 0033 */ "BitConverter",
             /* 0034 */ "BitPacked",
             /* 0035 */ "Boolean",
             /* 0036 */ "Break",
             /* 0037 */ "Byte",
             /* 0038 */ "ByteCode",
             /* 0039 */ "Ceiling",
             /* 003A */ "Change",
             /* 003B */ "Char",
             /* 003C */ "Check",
             /* 003D */ "Clear",
             /* 003E */ "Clone",
             /* 003F */ "Close",
             /* 0040 */ "Combine",
             /* 0041 */ "CombineArrays",
             /* 0042 */ "Compare",
             /* 0043 */ "CompareExchange",
             /* 0044 */ "CompareTo",
             /* 0045 */ "ComputeCRC",
             /* 0046 */ "Concat",
             /* 0047 */ "ConstraintException",
             /* 0048 */ "ConstructorInfo",
             /* 0049 */ "ContactHeight",
             /* 004A */ "ContactWidth",
             /* 004B */ "Contains",
             /* 004C */ "Convert",
             /* 004D */ "Copy",
             /* 004E */ "CopyTo",
             /* 004F */ "CopyToCollection",
             /* 0050 */ "Cos",
             /* 0051 */ "Cosh",
             /* 0052 */ "CreateDomain",
             /* 0053 */ "CreateInstance",
             /* 0054 */ "CreateInstanceAndUnwrap",
             /* 0055 */ "CultureInfo",
             /* 0056 */ "CultureTypes",
             /* 0057 */ "CurrentSystemTimeZone",
             /* 0058 */ "DateTime",
             /* 0059 */ "DateTimeFormat",
             /* 005A */ "DateTimeFormatInfo",
             /* 005B */ "DateTimeKind",
             /* 005C */ "Day",
             /* 005D */ "DayOfWeek",
             /* 005E */ "DaylightBias",
             /* 005F */ "DaylightDate",
             /* 0060 */ "DaylightName",
             /* 0061 */ "DaylightTime",
             /* 0062 */ "DaysInMonth",
             /* 0063 */ "Debug",
             /* 0064 */ "DebuggableAttribute",
             /* 0065 */ "Debugger",
             /* 0066 */ "DebuggingModes",
             /* 0067 */ "Decoder",
             /* 0068 */ "Decrement",
             /* 0069 */ "Delegate",
             /* 006A */ "Dequeue",
             /* 006B */ "Deserialize",
             /* 006C */ "DictionaryEntry",
             /* 006D */ "Dispose",
             /* 006E */ "Double",
             /* 006F */ "DoubleToInt64Bits",
             /* 0070 */ "Duration",
             /* 0071 */ "EditorBrowsableState",
             /* 0072 */ "Empty",
             /* 0073 */ "EnableGCMessages",
             /* 0074 */ "Encoding",
             /* 0075 */ "EndInvoke",
             /* 0076 */ "EndPoint",
             /* 0077 */ "Enqueue",
             /* 0078 */ "EnsureCapacity",
             /* 0079 */ "EnsureStringArrayResource",
             /* 007A */ "EnsureStringResource",
             /* 007B */ "Enter",
             /* 007C */ "Entry",
             /* 007D */ "EntryForKey",
             /* 007E */ "Enum",
             /* 007F */ "EnumeratorType",
             /* 0080 */ "Equals",
             /* 0081 */ "EventArgs",
             /* 0082 */ "EventCategory",
             /* 0083 */ "EventData",
             /* 0084 */ "EventMessage",
             /* 0085 */ "Exception",
             /* 0086 */ "Exchange",
             /* 0087 */ "ExecutionConstraint",
             /* 0088 */ "Exit",
             /* 0089 */ "Exp",
             /* 008A */ "ExpandByABlock",
             /* 008B */ "ExtendedTimer",
             /* 008C */ "ExtendedWeakReference",
             /* 008D */ "ExtensionAttribute",
             /* 008E */ "ExtractRangeFromArray",
             /* 008F */ "ExtractValueFromArray",
             /* 0090 */ "FalseString",
             /* 0091 */ "FieldDef",
             /* 0092 */ "FieldDefElements",
             /* 0093 */ "FieldInfo",
             /* 0094 */ "FieldRef",
             /* 0095 */ "FieldRefElements",
             /* 0096 */ "Finalize",
             /* 0097 */ "FindChunkForIndex",
             /* 0098 */ "FindResource",
             /* 0099 */ "Flags",
             /* 009A */ "Floor",
             /* 009B */ "Flush",
             /* 009C */ "FlushAll",
             /* 009D */ "Format",
             /* 009E */ "FormatCustomized",
             /* 009F */ "FormatDigits",
             /* 00A0 */ "FormatNative",
             /* 00A1 */ "FromBase64CharArray",
             /* 00A2 */ "FromBase64String",
             /* 00A3 */ "FromTicks",
             /* 00A4 */ "GC",
             /* 00A5 */ "GenericEvent",
             /* 00A6 */ "Gesture",
             /* 00A7 */ "GetAssemblies",
             /* 00A8 */ "GetAssembly",
             /* 00A9 */ "GetAssemblyFromHash",
             /* 00AA */ "GetAssemblyHash",
             /* 00AB */ "GetAssemblyInfo",
             /* 00AC */ "GetAssemblyMemoryInfo",
             /* 00AD */ "GetBase64EncodedLength",
             /* 00AE */ "GetBytes",
             /* 00AF */ "GetChars",
             /* 00B0 */ "GetConstructor",
             /* 00B1 */ "GetCultures",
             /* 00B2 */ "GetDaylightChanges",
             /* 00B3 */ "GetDecoder",
             /* 00B4 */ "GetDelimitedStringResource",
             /* 00B5 */ "GetDelimitedStringResources",
             /* 00B6 */ "GetDomain",
             /* 00B7 */ "GetDoubleNumber",
             /* 00B8 */ "GetEffectiveDate",
             /* 00B9 */ "GetElementType",
             /* 00BA */ "GetEnumerator",
             /* 00BB */ "GetExecutingAssembly",
             /* 00BC */ "GetExpirationDate",
             /* 00BD */ "GetField",
             /* 00BE */ "GetFields",
             /* 00BF */ "GetFormat",
             /* 00C0 */ "GetHashCode",
             /* 00C1 */ "GetInterfaces",
             /* 00C2 */ "GetMachineTime",
             /* 00C3 */ "GetManifestResourceNames",
             /* 00C4 */ "GetMessage",
             /* 00C5 */ "GetMethod",
             /* 00C6 */ "GetMethods",
             /* 00C7 */ "GetName",
             /* 00C8 */ "GetObject",
             /* 00C9 */ "GetObjectChunkFromId",
             /* 00CA */ "GetObjectFromId",
             /* 00CB */ "GetObjectInternal",
             /* 00CC */ "GetObjectValue",
             /* 00CD */ "GetParentCultureName",
             /* 00CE */ "GetPosition",
             /* 00CF */ "GetRawCertData",
             /* 00D0 */ "GetRealFormat",
             /* 00D1 */ "GetSatelliteAssembly",
             /* 00D2 */ "GetString",
             /* 00D3 */ "GetSystemVersion",
             /* 00D4 */ "GetTimeZoneOffset",
             /* 00D5 */ "GetType",
             /* 00D6 */ "GetTypeFromHandle",
             /* 00D7 */ "GetTypeFromHash",
             /* 00D8 */ "GetTypeHash",
             /* 00D9 */ "GetTypeInternal",
             /* 00DA */ "GetTypes",
             /* 00DB */ "GetTypesImplementingInterface",
             /* 00DC */ "GetUtcOffset",
             /* 00DD */ "GetValue",
             /* 00DE */ "GetVersion",
             /* 00DF */ "GloballySynchronizedAttribute",
             /* 00E0 */ "Guid",
             /* 00E1 */ "Hash",
             /* 00E2 */ "Hashtable",
             /* 00E3 */ "HashtableEnumerator",
             /* 00E4 */ "HexToChar",
             /* 00E5 */ "Hour",
             /* 00E6 */ "IAsyncResult",
             /* 00E7 */ "ICloneable",
             /* 00E8 */ "ICollection",
             /* 00E9 */ "IComparable",
             /* 00EA */ "IComparer",
             /* 00EB */ "ICustomFormatter",
             /* 00EC */ "IDictionary",
             /* 00ED */ "IDisposable",
             /* 00EE */ "IEEERemainder",
             /* 00EF */ "IEnumerable",
             /* 00F0 */ "IEnumerator",
             /* 00F1 */ "IEqualityComparer",
             /* 00F2 */ "IEventListener",
             /* 00F3 */ "IEventProcessor",
             /* 00F4 */ "IFormatProvider",
             /* 00F5 */ "IFormattable",
             /* 00F6 */ "IList",
             /* 00F7 */ "ILog",
             /* 00F8 */ "IOException",
             /* 00F9 */ "IOExceptionErrorCode",
             /* 00FA */ "IReflect",
             /* 00FB */ "Increment",
             /* 00FC */ "IndexOf",
             /* 00FD */ "IndexOfAny",
             /* 00FE */ "IndexOutOfRangeException",
             /* 00FF */ "Initialize",
             /* 0100 */ "InitializeArray",
             /* 0101 */ "InitializeForEventSource",
             /* 0102 */ "InitializeHashTable",
             /* 0103 */ "Insert",
             /* 0104 */ "InsertGroupSeperators",
             /* 0105 */ "InsertValueIntoArray",
             /* 0106 */ "Install",
             /* 0107 */ "Int16",
             /* 0108 */ "Int32",
             /* 0109 */ "Int64",
             /* 010A */ "Int64BitsToDouble",
             /* 010B */ "IntPtr",
             /* 010C */ "Interlocked",
             /* 010D */ "Intern",
             /* 010E */ "InvalidCastException",
             /* 010F */ "InvalidOperationException",
             /* 0110 */ "Invoke",
             /* 0111 */ "InvokeMember",
             /* 0112 */ "IsDaylightSavingTime",
             /* 0113 */ "IsEmulator",
             /* 0114 */ "IsInfinity",
             /* 0115 */ "IsInstanceOfType",
             /* 0116 */ "IsInterned",
             /* 0117 */ "IsNaN",
             /* 0118 */ "IsNegativeInfinity",
             /* 0119 */ "IsPositiveInfinity",
             /* 011A */ "IsSubclassOf",
             /* 011B */ "IsTransparentProxy",
             /* 011C */ "IsTypeLoaded",
             /* 011D */ "Join",
             /* 011E */ "Key",
             /* 011F */ "KeyCollection",
             /* 0120 */ "LastIndexOf",
             /* 0121 */ "LastIndexOfAny",
             /* 0122 */ "Load",
             /* 0123 */ "LoadInternal",
             /* 0124 */ "Log",
             /* 0125 */ "Log10",
             /* 0126 */ "MakeRoom",
             /* 0127 */ "ManualResetEvent",
             /* 0128 */ "MarshalByRefObject",
             /* 0129 */ "Math",
             /* 012A */ "Max",
             /* 012B */ "MaxValue",
             /* 012C */ "MemberInfo",
             /* 012D */ "MemberTypes",
             /* 012E */ "MemberwiseClone",
             /* 012F */ "Message",
             /* 0130 */ "MetadataSize",
             /* 0131 */ "MethodBase",
             /* 0132 */ "MethodDef",
             /* 0133 */ "MethodDefElements",
             /* 0134 */ "MethodInfo",
             /* 0135 */ "MethodRef",
             /* 0136 */ "MethodRefElements",
             /* 0137 */ "Microsoft.SPOT",
             /* 0138 */ "Microsoft.SPOT.Hardware",
             /* 0139 */ "Microsoft.SPOT.Messaging",
             /* 013A */ "Microsoft.SPOT.Touch",
             /* 013B */ "Milliseconds",
             /* 013C */ "Min",
             /* 013D */ "MinValue",
             /* 013E */ "Minute",
             /* 013F */ "Monitor",
             /* 0140 */ "Month",
             /* 0141 */ "MoveNext",
             /* 0142 */ "MulticastDelegate",
             /* 0143 */ "Native_Resources",
             /* 0144 */ "Negate",
             /* 0145 */ "NewGuid",
             /* 0146 */ "Next",
             /* 0147 */ "NextBytes",
             /* 0148 */ "NextDouble",
             /* 0149 */ "NotImplementedException",
             /* 014A */ "NotSupportedException",
             /* 014B */ "NullReferenceException",
             /* 014C */ "Number",
             /* 014D */ "NumberFormatInfo",
             /* 014E */ "Object",
             /* 014F */ "ObjectDisposedException",
             /* 0150 */ "OnEvent",
             /* 0151 */ "OutOfMemoryException",
             /* 0152 */ "Parse",
             /* 0153 */ "ParseAssemblyName",
             /* 0154 */ "ParseCertificate",
             /* 0155 */ "ParseNextChar",
             /* 0156 */ "ParseQuoteString",
             /* 0157 */ "ParseRepeatPattern",
             /* 0158 */ "ParseTypeName",
             /* 0159 */ "Peek",
             /* 015A */ "Piezo",
             /* 015B */ "Pop",
             /* 015C */ "PostProcessFloat",
             /* 015D */ "PostProcessInteger",
             /* 015E */ "Pow",
             /* 015F */ "Print",
             /* 0160 */ "PriorityLevel",
             /* 0161 */ "ProcessEvent",
             /* 0162 */ "ProcessorArchitecture",
             /* 0163 */ "PropertyInfo",
             /* 0164 */ "Push",
             /* 0165 */ "PushBackIntoRecoverList",
             /* 0166 */ "Queue",
             /* 0167 */ "Raise",
             /* 0168 */ "RamSize",
             /* 0169 */ "Random",
             /* 016A */ "RangeBias",
             /* 016B */ "ReRegisterForFinalize",
             /* 016C */ "Read",
             /* 016D */ "ReadByte",
             /* 016E */ "Recover",
             /* 016F */ "RecoverOrCreate",
             /* 0170 */ "ReferenceEquals",
             /* 0171 */ "Reflection",
             /* 0172 */ "Rehash",
             /* 0173 */ "RemotedException",
             /* 0174 */ "RemotingServices",
             /* 0175 */ "Remove",
             /* 0176 */ "RemoveAt",
             /* 0177 */ "Replace",
             /* 0178 */ "ReplaceAllInChunk",
             /* 0179 */ "ReplaceDecimalSeperator",
             /* 017A */ "ReplaceInPlaceAtChunk",
             /* 017B */ "ReplaceNegativeSign",
             /* 017C */ "Reply",
             /* 017D */ "ReplyRaw",
             /* 017E */ "Reset",
             /* 017F */ "ResourceManager",
             /* 0180 */ "ResourceUtility",
             /* 0181 */ "Resources",
             /* 0182 */ "ResourcesData",
             /* 0183 */ "ResourcesElements",
             /* 0184 */ "ResourcesFiles",
             /* 0185 */ "ResourcesFilesElements",
             /* 0186 */ "Resume",
             /* 0187 */ "RomSize",
             /* 0188 */ "Round",
             /* 0189 */ "RunClassConstructor",
             /* 018A */ "RuntimeArgumentHandle",
             /* 018B */ "RuntimeConstructorInfo",
             /* 018C */ "RuntimeFieldHandle",
             /* 018D */ "RuntimeFieldInfo",
             /* 018E */ "RuntimeHelpers",
             /* 018F */ "RuntimeMethodHandle",
             /* 0190 */ "RuntimeMethodInfo",
             /* 0191 */ "RuntimeType",
             /* 0192 */ "RuntimeTypeHandle",
             /* 0193 */ "SByte",
             /* 0194 */ "SZArrayEnumerator",
             /* 0195 */ "Scale",
             /* 0196 */ "Second",
             /* 0197 */ "Seek",
             /* 0198 */ "SeekOrigin",
             /* 0199 */ "SendMessage",
             /* 019A */ "SendMessageRaw",
             /* 019B */ "SerializationFlags",
             /* 019C */ "SerializationHintsAttribute",
             /* 019D */ "Serialize",
             /* 019E */ "Set",
             /* 019F */ "SetCapacity",
             /* 01A0 */ "SetCurrentUICulture",
             /* 01A1 */ "SetLength",
             /* 01A2 */ "SetLocalTime",
             /* 01A3 */ "SetValue",
             /* 01A4 */ "Sign",
             /* 01A5 */ "Signatures",
             /* 01A6 */ "Sin",
             /* 01A7 */ "Single",
             /* 01A8 */ "Sinh",
             /* 01A9 */ "Sleep",
             /* 01AA */ "Source",
             /* 01AB */ "SourceID",
             /* 01AC */ "SpecifyKind",
             /* 01AD */ "Split",
             /* 01AE */ "Sqrt",
             /* 01AF */ "Stack",
             /* 01B0 */ "StandardBias",
             /* 01B1 */ "StandardDate",
             /* 01B2 */ "StandardName",
             /* 01B3 */ "Start",
             /* 01B4 */ "StartsWith",
             /* 01B5 */ "StaticFields",
             /* 01B6 */ "Stream",
             /* 01B7 */ "String",
             /* 01B8 */ "StringBuilder",
             /* 01B9 */ "StringResources",
             /* 01BA */ "Strings",
             /* 01BB */ "Substring",
             /* 01BC */ "Subtract",
             /* 01BD */ "SuppressFinalize",
             /* 01BE */ "Suspend",
             /* 01BF */ "System",
             /* 01C0 */ "System.Collections",
             /* 01C1 */ "System.Collections.ICollection.get_Count",
             /* 01C2 */ "System.Collections.IList.Add",
             /* 01C3 */ "System.Collections.IList.Clear",
             /* 01C4 */ "System.Collections.IList.Contains",
             /* 01C5 */ "System.Collections.IList.IndexOf",
             /* 01C6 */ "System.Collections.IList.Insert",
             /* 01C7 */ "System.Collections.IList.Remove",
             /* 01C8 */ "System.Collections.IList.RemoveAt",
             /* 01C9 */ "System.Collections.IList.get_Item",
             /* 01CA */ "System.Collections.IList.set_Item",
             /* 01CB */ "System.ComponentModel",
             /* 01CC */ "System.Diagnostics",
             /* 01CD */ "System.Globalization",
             /* 01CE */ "System.Globalization.Resources",
             /* 01CF */ "System.IO",
             /* 01D0 */ "System.Reflection",
             /* 01D1 */ "System.Resources",
             /* 01D2 */ "System.Runtime.CompilerServices",
             /* 01D3 */ "System.Runtime.Remoting",
             /* 01D4 */ "System.Runtime.Versioning",
             /* 01D5 */ "System.Security.Cryptography.X509Certificates",
             /* 01D6 */ "System.Text",
             /* 01D7 */ "System.Threading",
             /* 01D8 */ "SystemException",
             /* 01D9 */ "SystemID",
             /* 01DA */ "SystemInfo",
             /* 01DB */ "SystemTime",
             /* 01DC */ "Tan",
             /* 01DD */ "Tanh",
             /* 01DE */ "Target",
             /* 01DF */ "TargetFrameworkAttribute",
             /* 01E0 */ "Thread",
             /* 01E1 */ "ThreadAbortException",
             /* 01E2 */ "ThreadPriority",
             /* 01E3 */ "ThreadStart",
             /* 01E4 */ "ThreadState",
             /* 01E5 */ "Time",
             /* 01E6 */ "TimeEvents",
             /* 01E7 */ "TimeSpan",
             /* 01E8 */ "TimeStamp",
             /* 01E9 */ "TimeZone",
             /* 01EA */ "TimeZoneId",
             /* 01EB */ "TimeZoneInformation",
             /* 01EC */ "Timer",
             /* 01ED */ "TimerCallback",
             /* 01EE */ "Timestamp",
             /* 01EF */ "ToArray",
             /* 01F0 */ "ToBase64String",
             /* 01F1 */ "ToBoolean",
             /* 01F2 */ "ToByte",
             /* 01F3 */ "ToByteArray",
             /* 01F4 */ "ToChar",
             /* 01F5 */ "ToCharArray",
             /* 01F6 */ "ToDouble",
             /* 01F7 */ "ToInt16",
             /* 01F8 */ "ToInt32",
             /* 01F9 */ "ToInt64",
             /* 01FA */ "ToLocalTime",
             /* 01FB */ "ToLower",
             /* 01FC */ "ToSByte",
             /* 01FD */ "ToSingle",
             /* 01FE */ "ToString",
             /* 01FF */ "ToUInt16",
             /* 0200 */ "ToUInt32",
             /* 0201 */ "ToUInt64",
             /* 0202 */ "ToUniversalTime",
             /* 0203 */ "ToUpper",
             /* 0204 */ "TouchEvent",
             /* 0205 */ "TouchGesture",
             /* 0206 */ "TouchGestureEventArgs",
             /* 0207 */ "TouchGestureEventHandler",
             /* 0208 */ "TouchInput",
             /* 0209 */ "TouchInputFlags",
             /* 020A */ "TouchMessages",
             /* 020B */ "TouchScreenEventArgs",
             /* 020C */ "TouchScreenEventHandler",
             /* 020D */ "Touches",
             /* 020E */ "Trace",
             /* 020F */ "Trim",
             /* 0210 */ "TrimEnd",
             /* 0211 */ "TrimStart",
             /* 0212 */ "TrueString",
             /* 0213 */ "Truncate",
             /* 0214 */ "TryParse",
             /* 0215 */ "TrySZIndexOf",
             /* 0216 */ "Type",
             /* 0217 */ "TypeCode",
             /* 0218 */ "TypeDef",
             /* 0219 */ "TypeDefElements",
             /* 021A */ "TypeRef",
             /* 021B */ "TypeRefElements",
             /* 021C */ "TypeSpec",
             /* 021D */ "TypeSpecElements",
             /* 021E */ "UInt16",
             /* 021F */ "UInt32",
             /* 0220 */ "UInt64",
             /* 0221 */ "UTF8Decoder",
             /* 0222 */ "UTF8Encoding",
             /* 0223 */ "UnknownTypeException",
             /* 0224 */ "Unload",
             /* 0225 */ "Utility",
             /* 0226 */ "ValidateFormat",
             /* 0227 */ "Value",
             /* 0228 */ "ValueCollection",
             /* 0229 */ "ValueType",
             /* 022A */ "Version",
             /* 022B */ "Void",
             /* 022C */ "WaitAll",
             /* 022D */ "WaitAny",
             /* 022E */ "WaitForPendingFinalizers",
             /* 022F */ "WaitHandle",
             /* 0230 */ "WaitMultiple",
             /* 0231 */ "WaitOne",
             /* 0232 */ "WeakDelegate",
             /* 0233 */ "WeakReference",
             /* 0234 */ "Write",
             /* 0235 */ "WriteByte",
             /* 0236 */ "X",
             /* 0237 */ "X509Certificate",
             /* 0238 */ "Y",
             /* 0239 */ "Year",
             /* 023A */ "Zero",
             /* 023B */ "_Build",
             /* 023C */ "_Major",
             /* 023D */ "_Minor",
             /* 023E */ "_Revision",
             /* 023F */ "_array",
             /* 0240 */ "_arrayLength",
             /* 0241 */ "_assembly",
             /* 0242 */ "_buckets",
             /* 0243 */ "_count",
             /* 0244 */ "_endIndex",
             /* 0245 */ "_frameworkDisplayName",
             /* 0246 */ "_frameworkName",
             /* 0247 */ "_growthFactor",
             /* 0248 */ "_head",
             /* 0249 */ "_index",
             /* 024A */ "_items",
             /* 024B */ "_loadFactor",
             /* 024C */ "_maxLoadFactor",
             /* 024D */ "_message",
             /* 024E */ "_numberOfBuckets",
             /* 024F */ "_random",
             /* 0250 */ "_size",
             /* 0251 */ "_startIndex",
             /* 0252 */ "_tail",
             /* 0253 */ "abbreviatedDayNames",
             /* 0254 */ "abbreviatedMonthNames",
             /* 0255 */ "amDesignator",
             /* 0256 */ "dateSeparator",
             /* 0257 */ "dateTimeInfo",
             /* 0258 */ "dayNames",
             /* 0259 */ "fullDateTimePattern",
             /* 025A */ "generalLongTimePattern",
             /* 025B */ "generalShortTimePattern",
             /* 025C */ "get_AMDesignator",
             /* 025D */ "get_AbbreviatedDayNames",
             /* 025E */ "get_AbbreviatedMonthNames",
             /* 025F */ "get_Angle",
             /* 0260 */ "get_Assembly",
             /* 0261 */ "get_AssemblyQualifiedName",
             /* 0262 */ "get_BaseType",
             /* 0263 */ "get_Build",
             /* 0264 */ "get_CanRead",
             /* 0265 */ "get_CanSeek",
             /* 0266 */ "get_CanTimeout",
             /* 0267 */ "get_CanWrite",
             /* 0268 */ "get_Capacity",
             /* 0269 */ "get_Chars",
             /* 026A */ "get_Count",
             /* 026B */ "get_Current",
             /* 026C */ "get_CurrentDomain",
             /* 026D */ "get_CurrentInfo",
             /* 026E */ "get_CurrentThread",
             /* 026F */ "get_CurrentTimeZone",
             /* 0270 */ "get_CurrentUICulture",
             /* 0271 */ "get_CurrentUICultureInternal",
             /* 0272 */ "get_Date",
             /* 0273 */ "get_DateSeparator",
             /* 0274 */ "get_DateTimeFormat",
             /* 0275 */ "get_Day",
             /* 0276 */ "get_DayNames",
             /* 0277 */ "get_DayOfWeek",
             /* 0278 */ "get_DayOfYear",
             /* 0279 */ "get_DaylightName",
             /* 027A */ "get_Days",
             /* 027B */ "get_DeclaringType",
             /* 027C */ "get_Delta",
             /* 027D */ "get_End",
             /* 027E */ "get_ErrorCode",
             /* 027F */ "get_FieldType",
             /* 0280 */ "get_Flags",
             /* 0281 */ "get_FrameworkDisplayName",
             /* 0282 */ "get_FrameworkName",
             /* 0283 */ "get_FriendlyName",
             /* 0284 */ "get_FullDateTimePattern",
             /* 0285 */ "get_FullName",
             /* 0286 */ "get_GeneralLongTimePattern",
             /* 0287 */ "get_GeneralShortTimePattern",
             /* 0288 */ "get_GrowthFactor",
             /* 0289 */ "get_Hour",
             /* 028A */ "get_Hours",
             /* 028B */ "get_Id",
             /* 028C */ "get_InnerException",
             /* 028D */ "get_IsAbstract",
             /* 028E */ "get_IsAlive",
             /* 028F */ "get_IsArray",
             /* 0290 */ "get_IsAttached",
             /* 0291 */ "get_IsBigEndian",
             /* 0292 */ "get_IsClass",
             /* 0293 */ "get_IsEnum",
             /* 0294 */ "get_IsFinal",
             /* 0295 */ "get_IsFixedSize",
             /* 0296 */ "get_IsInterface",
             /* 0297 */ "get_IsLittleEndian",
             /* 0298 */ "get_IsNotPublic",
             /* 0299 */ "get_IsPublic",
             /* 029A */ "get_IsReadOnly",
             /* 029B */ "get_IsSerializable",
             /* 029C */ "get_IsStatic",
             /* 029D */ "get_IsSynchronized",
             /* 029E */ "get_IsValid",
             /* 029F */ "get_IsValueType",
             /* 02A0 */ "get_IsVirtual",
             /* 02A1 */ "get_Issuer",
             /* 02A2 */ "get_Item",
             /* 02A3 */ "get_Keys",
             /* 02A4 */ "get_Kind",
             /* 02A5 */ "get_LastExpiration",
             /* 02A6 */ "get_Length",
             /* 02A7 */ "get_LongDatePattern",
             /* 02A8 */ "get_LongTimePattern",
             /* 02A9 */ "get_Major",
             /* 02AA */ "get_ManagedThreadId",
             /* 02AB */ "get_MaxCapacity",
             /* 02AC */ "get_MaxLoadFactor",
             /* 02AD */ "get_MemberType",
             /* 02AE */ "get_Message",
             /* 02AF */ "get_Method",
             /* 02B0 */ "get_Millisecond",
             /* 02B1 */ "get_Milliseconds",
             /* 02B2 */ "get_Minor",
             /* 02B3 */ "get_Minute",
             /* 02B4 */ "get_Minutes",
             /* 02B5 */ "get_Model",
             /* 02B6 */ "get_Month",
             /* 02B7 */ "get_MonthDayPattern",
             /* 02B8 */ "get_MonthNames",
             /* 02B9 */ "get_Name",
             /* 02BA */ "get_NegativeSign",
             /* 02BB */ "get_Now",
             /* 02BC */ "get_NumberDecimalSeparator",
             /* 02BD */ "get_NumberFormat",
             /* 02BE */ "get_NumberGroupSeparator",
             /* 02BF */ "get_NumberGroupSizes",
             /* 02C0 */ "get_OEM",
             /* 02C1 */ "get_OEMString",
             /* 02C2 */ "get_OffsetToStringData",
             /* 02C3 */ "get_PMDesignator",
             /* 02C4 */ "get_ParamName",
             /* 02C5 */ "get_Parent",
             /* 02C6 */ "get_Payload",
             /* 02C7 */ "get_PayloadRaw",
             /* 02C8 */ "get_Position",
             /* 02C9 */ "get_PositiveSign",
             /* 02CA */ "get_Priority",
             /* 02CB */ "get_PropertyName",
             /* 02CC */ "get_PropertyType",
             /* 02CD */ "get_RFC1123Pattern",
             /* 02CE */ "get_ReadTimeout",
             /* 02CF */ "get_ResourceManager",
             /* 02D0 */ "get_ReturnType",
             /* 02D1 */ "get_Revision",
             /* 02D2 */ "get_SKU",
             /* 02D3 */ "get_Second",
             /* 02D4 */ "get_Seconds",
             /* 02D5 */ "get_Selector",
             /* 02D6 */ "get_ShortDatePattern",
             /* 02D7 */ "get_ShortTimePattern",
             /* 02D8 */ "get_SortableDateTimePattern",
             /* 02D9 */ "get_StackTrace",
             /* 02DA */ "get_StandardName",
             /* 02DB */ "get_Start",
             /* 02DC */ "get_Subject",
             /* 02DD */ "get_SyncRoot",
             /* 02DE */ "get_Target",
             /* 02DF */ "get_ThreadState",
             /* 02E0 */ "get_Ticks",
             /* 02E1 */ "get_TimeOfDay",
             /* 02E2 */ "get_TimeSeparator",
             /* 02E3 */ "get_Today",
             /* 02E4 */ "get_UTF8",
             /* 02E5 */ "get_UniversalSortableDateTimePattern",
             /* 02E6 */ "get_UseRFC4648Encoding",
             /* 02E7 */ "get_UtcNow",
             /* 02E8 */ "get_Values",
             /* 02E9 */ "get_Version",
             /* 02EA */ "get_WriteTimeout",
             /* 02EB */ "get_Year",
             /* 02EC */ "get_YearMonthPattern",
             /* 02ED */ "ht",
             /* 02EE */ "index",
             /* 02EF */ "key",
             /* 02F0 */ "longDatePattern",
             /* 02F1 */ "longTimePattern",
             /* 02F2 */ "m_AppDomain",
             /* 02F3 */ "m_ChunkChars",
             /* 02F4 */ "m_ChunkLength",
             /* 02F5 */ "m_ChunkOffset",
             /* 02F6 */ "m_ChunkPrevious",
             /* 02F7 */ "m_Delegate",
             /* 02F8 */ "m_HResult",
             /* 02F9 */ "m_Id",
             /* 02FA */ "m_MaxCapacity",
             /* 02FB */ "m_Priority",
             /* 02FC */ "m_Thread",
             /* 02FD */ "m_appDomain",
             /* 02FE */ "m_assembly",
             /* 02FF */ "m_baseAssembly",
             /* 0300 */ "m_baseName",
             /* 0301 */ "m_callback",
             /* 0302 */ "m_certificate",
             /* 0303 */ "m_cultureInfo",
             /* 0304 */ "m_cultureName",
             /* 0305 */ "m_data",
             /* 0306 */ "m_delta",
             /* 0307 */ "m_effectiveDate",
             /* 0308 */ "m_end",
             /* 0309 */ "m_expirationDate",
             /* 030A */ "m_flags",
             /* 030B */ "m_friendlyName",
             /* 030C */ "m_handle",
             /* 030D */ "m_hash",
             /* 030E */ "m_id",
             /* 030F */ "m_innerException",
             /* 0310 */ "m_issuer",
             /* 0311 */ "m_message",
             /* 0312 */ "m_name",
             /* 0313 */ "m_paramName",
             /* 0314 */ "m_parent",
             /* 0315 */ "m_password",
             /* 0316 */ "m_payload",
             /* 0317 */ "m_rand",
             /* 0318 */ "m_refs",
             /* 0319 */ "m_resourceFileId",
             /* 031A */ "m_rm",
             /* 031B */ "m_rmFallback",
             /* 031C */ "m_selector",
             /* 031D */ "m_seq",
             /* 031E */ "m_sessionHandle",
             /* 031F */ "m_size",
             /* 0320 */ "m_source",
             /* 0321 */ "m_stackTrace",
             /* 0322 */ "m_start",
             /* 0323 */ "m_state",
             /* 0324 */ "m_subject",
             /* 0325 */ "m_ticks",
             /* 0326 */ "m_ticksOffset",
             /* 0327 */ "m_timer",
             /* 0328 */ "m_type",
             /* 0329 */ "m_value",
             /* 032A */ "manager",
             /* 032B */ "monthDayPattern",
             /* 032C */ "monthNames",
             /* 032D */ "mscorlib",
             /* 032E */ "negativeSign",
             /* 032F */ "next",
             /* 0330 */ "numInfo",
             /* 0331 */ "numberDecimalSeparator",
             /* 0332 */ "numberGroupSeparator",
             /* 0333 */ "numberGroupSizes",
             /* 0334 */ "op_Addition",
             /* 0335 */ "op_Equality",
             /* 0336 */ "op_GreaterThan",
             /* 0337 */ "op_GreaterThanOrEqual",
             /* 0338 */ "op_Inequality",
             /* 0339 */ "op_LessThan",
             /* 033A */ "op_LessThanOrEqual",
             /* 033B */ "op_Subtraction",
             /* 033C */ "op_UnaryNegation",
             /* 033D */ "op_UnaryPlus",
             /* 033E */ "pmDesignator",
             /* 033F */ "positiveSign",
             /* 0340 */ "propertyName",
             /* 0341 */ "returnType",
             /* 0342 */ "s_ewr",
             /* 0343 */ "s_rgbBase64Decode",
             /* 0344 */ "s_rgchBase64Encoding",
             /* 0345 */ "s_rgchBase64EncodingDefault",
             /* 0346 */ "s_rgchBase64EncodingRFC4648",
             /* 0347 */ "set_Capacity",
             /* 0348 */ "set_CurrentUICultureInternal",
             /* 0349 */ "set_FrameworkDisplayName",
             /* 034A */ "set_GrowthFactor",
             /* 034B */ "set_Item",
             /* 034C */ "set_Length",
             /* 034D */ "set_MaxLoadFactor",
             /* 034E */ "set_Position",
             /* 034F */ "set_Priority",
             /* 0350 */ "set_ReadTimeout",
             /* 0351 */ "set_Target",
             /* 0352 */ "set_UseRFC4648Encoding",
             /* 0353 */ "set_WriteTimeout",
             /* 0354 */ "shortDatePattern",
             /* 0355 */ "shortTimePattern",
             /* 0356 */ "temp",
             /* 0357 */ "ticksAtOrigin",
             /* 0358 */ "timeSeparator",
             /* 0359 */ "value",
             /* 035A */ "value__",
             /* 035B */ "yearMonthPattern",
        }
            .Select((value, index) => new {value, index = (ushort) (0xFFFF - index)})
            .ToDictionary(item => item.value, item => item.index, StringComparer.Ordinal);
    }
}
