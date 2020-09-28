using System;
using System.Runtime.InteropServices;

namespace SpoolSamplerNET
{
    internal class NativeMethods
    {
        [DllImport("Rpcrt4.dll", EntryPoint = "RpcBindingFromStringBindingW",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Unicode, SetLastError = false)]
        internal static extern Int32 RpcBindingFromStringBinding(String bindingString, out IntPtr lpBinding);

        [DllImport("Rpcrt4.dll", EntryPoint = "NdrClientCall2", CallingConvention = CallingConvention.Cdecl,
            CharSet = CharSet.Unicode, SetLastError = false)]
        internal static extern IntPtr NdrClientCall2x64(IntPtr pMIDL_STUB_DESC, IntPtr formatString, ref IntPtr Handle);


        [DllImport("Rpcrt4.dll", EntryPoint = "NdrClientCall2", CallingConvention = CallingConvention.Cdecl,
            CharSet = CharSet.Unicode, SetLastError = false)]
        internal static extern IntPtr NdrClientCall2x86(IntPtr pMIDL_STUB_DESC, IntPtr formatString, IntPtr args);

        [DllImport("Rpcrt4.dll", EntryPoint = "NdrClientCall2", CallingConvention = CallingConvention.Cdecl,
            CharSet = CharSet.Unicode, SetLastError = false)]
        internal static extern IntPtr NdrClientCall2x64(IntPtr intPtr1, IntPtr intPtr2, string pPrinterName,
            out IntPtr pHandle, string pDatatype, ref Program.rprn.DEVMODE_CONTAINER pDevModeContainer,
            int AccessRequired);

        [DllImport("Rpcrt4.dll", EntryPoint = "NdrClientCall2", CallingConvention = CallingConvention.Cdecl,
            CharSet = CharSet.Unicode, SetLastError = false)]
        internal static extern IntPtr NdrClientCall2x64(IntPtr intPtr1, IntPtr intPtr2, IntPtr hPrinter, uint fdwFlags,
            uint fdwOptions, string pszLocalMachine, uint dwPrinterLocal, IntPtr intPtr3);


        [DllImport("Rpcrt4.dll", EntryPoint = "RpcBindingFree", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Unicode, SetLastError = false)]
        internal static extern Int32 RpcBindingFree(ref IntPtr lpString);

        //#region RpcStringBindingCompose

        [DllImport("Rpcrt4.dll", EntryPoint = "RpcStringBindingComposeW", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Unicode, SetLastError = false)]
        internal static extern Int32 RpcStringBindingCompose(
            String ObjUuid, String ProtSeq, String NetworkAddr, String Endpoint, String Options,
            out IntPtr lpBindingString
        );

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct SEC_WINNT_AUTH_IDENTITY
        {
            [MarshalAs(UnmanagedType.LPWStr)] public string User;
            public int UserLength;
            [MarshalAs(UnmanagedType.LPWStr)] public string Domain;
            public int DomainLength;
            [MarshalAs(UnmanagedType.LPWStr)] public string Password;
            public int PasswordLength;
            public int Flags;
        };

        [StructLayout(LayoutKind.Sequential)]
        public struct RPC_SECURITY_QOS
        {
            public Int32 Version;
            public Int32 Capabilities;
            public Int32 IdentityTracking;
            public Int32 ImpersonationType;
        };


        [DllImport("Rpcrt4.dll", EntryPoint = "RpcBindingSetAuthInfoExW", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Unicode, SetLastError = false)]
        internal static extern Int32 RpcBindingSetAuthInfoEx(IntPtr lpBinding, string ServerPrincName,
            UInt32 AuthnLevel, UInt32 AuthnSvc, ref SEC_WINNT_AUTH_IDENTITY AuthIdentity, UInt32 AuthzSvc,
            ref RPC_SECURITY_QOS SecurityQOS);

        [DllImport("Rpcrt4.dll", EntryPoint = "RpcBindingSetOption", CallingConvention = CallingConvention.StdCall,
            SetLastError = false)]
        internal static extern Int32 RpcBindingSetOption(IntPtr Binding, UInt32 Option, UInt32 OptionValue);

    }
}