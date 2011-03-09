using System;
using System.Collections.Generic;
using System.Text;
using Castle.ActiveRecord;
using Castle.Components.Validator;

namespace MovilDomain
{
    [ActiveRecord(Table = "Multas")]
    public class Multa : ActiveRecordValidationBase<Multa>
    {
        public Multa()
        {
        }

        [PrimaryKey(PrimaryKeyType.Native)]
        public int Id
        {
            get;
            set;
        }

        [Property(NotNull = true, Length = 100)]
        [ValidateNonEmpty("No debe estar Vacio")]
        public string DescMulta
        {
            get;
            set;
        }

        [BelongsTo("PlacaId", NotNull = true)]
        public Placa placa
        {
            get;
            set;
        }

        [BelongsTo("LicenciaId", NotNull = true)]
        public Licencia licencia
        {
            get;
            set;
        }
    }
}
