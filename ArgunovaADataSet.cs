namespace ArgunovaMaterial
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    public partial class ArgunovaADataSet
    {
        private static ArgunovaADataSet_Argunova;
        public ArgunovaADataSet()
            : base ("name=ArgunovaADataSet")
        {
        }
        public static ArgunovaADataSet GetArgunova()
        {
            if (_context == null)
        }

           
    }
}
