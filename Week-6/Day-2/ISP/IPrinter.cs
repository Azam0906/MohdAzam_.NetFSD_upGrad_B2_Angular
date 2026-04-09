using System;

namespace oopsDesignDemo.ISP
{
    interface IPrinter
    {
        void Print();
    }
    interface IScanner
    {
        void Scan();
    }

    interface IFax
    {
        void Fax();
    }
}
