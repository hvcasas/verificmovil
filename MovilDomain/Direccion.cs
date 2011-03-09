using System;
using System.Collections.Generic;
using System.Text;
using Castle.ActiveRecord;
using Castle.Components.Validator;
namespace MovilDomain
{
    [ActiveRecord(Table = "Direcciones")]
    public class Direccion : ActiveRecordValidationBase<Direccion>
    {
        public Direccion()
        {
        }

        [PrimaryKey(PrimaryKeyType.Native)]
        public int Id
        {
            get;
            set;
        }

        [Property(NotNull = true,Length = 50)]
        [ValidateNonEmpty("No debe estar Vacio")]
        public string Calle_Numero
        {
            get;
            set;
        }

        [Property(NotNull = true, Length = 30)]
        [ValidateNonEmpty("No debe estar Vacio")]
        public string Colonia
        {
            get;
            set;
        }


        [Property(NotNull = true, Length = 30)]
        [ValidateNonEmpty("No debe estar Vacio")]
        public string Ciudad
        {
            get;
            set;
        }

        [Property(NotNull = true, Length = 30)]
        [ValidateNonEmpty("No debe estar Vacio")]
        public string Estado
        {
            get;
            set;
        }

        [Property(NotNull = true, Length = 20)]
        [ValidateNonEmpty("No debe estar Vacio")]
        public string Pais
        {
            get;
            set;
        }

        [Property(NotNull = true)]
        [ValidateNonEmpty("No debe estar Vacio")]
        public int CP
        {
            get;
            set;
        }

    }
}
