using SignsCreatorWeb.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace SignsCreatorWeb.Application.Services
{
    public class KompasService : IKompasService
    {

        //    public static KompasObject kompas;
        //    public static IApplication KompasAPIObject;
        //    public static KompasObject KompasObject;
        //    public KompasService()
        //    {

        //    }

        //    public bool OpenKompas()
        //    {
        //        if (kompas == null)
        //        {

        //            Type t = Type.GetTypeFromProgID("KOMPAS.Application.5");
        //            try
        //            {
        //                kompas = (KompasObject)Marshal.GetActiveObject("KOMPAS.Application.5");
        //            }
        //            catch
        //            {

        //            }
        //            if (kompas == null)
        //            {
        //                kompas = (KompasObject)Activator.CreateInstance(t);
        //            }
        //        }
        //        if (kompas != null)
        //        {

        //            KompasObject = (KompasObject)kompas;
        //            KompasAPIObject = (IApplication)KompasObject.ksGetApplication7();
        //            kompas.Visible = true;
        //            kompas.ActivateControllerAPI();
        //        }

        //        if (KompasAPIObject != null)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //}


        //internal static class Marshal
        //{
        //    public static object? GetActiveObject(string progId) => GetActiveObject(progId, true);
        //    public static object? GetActiveObject(string progId, bool throwOnError = true)
        //    {
        //        if (progId == null)
        //            throw new ArgumentNullException(nameof(progId));

        //        var hr = CLSIDFromProgIDEx(progId, out var clsid);
        //        if (hr < 0)
        //        {
        //            if (throwOnError)
        //                System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(hr);

        //            return null;
        //        }

        //        hr = GetActiveObject(clsid, 0, out var obj);
        //        if (hr < 0)
        //        {
        //            if (throwOnError)
        //                System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(hr);

        //            return null;
        //        }
        //        return obj;
        //    }
        //    [DllImport("ole32")]
        //    private static extern int CLSIDFromProgIDEx([MarshalAs(UnmanagedType.LPWStr)] string lpszProgID, out Guid lpclsid);

        //    [DllImport("oleaut32")]
        //    private static extern int GetActiveObject([MarshalAs(UnmanagedType.LPStruct)] Guid rclsid, IntPtr pvReserved, [MarshalAs(UnmanagedType.IUnknown)] out object ppunk);
        //}
        public bool OpenKompas()
        {
            throw new NotImplementedException();
        }
    }
}
