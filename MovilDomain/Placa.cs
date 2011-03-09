using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.ActiveRecord;
using Castle.Components.Validator;

namespace MovilDomain
{
    [ActiveRecord(Table = "Placas")]
    public class Placa : ActiveRecordValidationBase<Placa>
    {
        private IList<Multa> multas = new List<Multa>();
        private IList<OrdAprehension> ordsAprehension = new List<OrdAprehension>();

        public Placa()
        { 
        }

        [PrimaryKey(PrimaryKeyType.Native)]
        public int Id
        {
            get;
            set;
        }

        [Property(NotNull = true, Length = 7)]
        [ValidateNonEmpty("No debe estar Vacio")]
        public string NoPlaca
        {
            get;
            set;
        }

        [Property(NotNull = true)]
        [ValidateNonEmpty("No debe estar Vacio")]
        public DateTime Vigencia
        {
            get;
            set;
        }

        [Property(NotNull = true, Length = 30)]
        [ValidateNonEmpty("No debe estar Vacio")]
        public string Marca
        {
            get;
            set;
        }

        [Property(NotNull = true)]
        [ValidateNonEmpty("No debe estar Vacio")]
        public int Modelo
        {
            get;
            set;
        }

        [Property(NotNull = true, Length = 50)]
        [ValidateNonEmpty("No debe estar Vacio")]
        public string Serie
        {
            get;
            set;
        }

        [Property(NotNull = true, Length = 30)]
        [ValidateNonEmpty("No debe estar Vacio")]
        public string Tipo
        {
            get;
            set;
        }

        [Property(NotNull = true, Length = 20)]
        [ValidateNonEmpty("No debe estar Vacio")]
        public string Color
        {
            get;
            set;
        }

        [Property(NotNull = true)]
        [ValidateNonEmpty("No debe estar Vacio")]
        public int Cilindros
        {
            get;
            set;
        }

        [Property(NotNull = true, Length = 100)]
        [ValidateNonEmpty("No debe estar Vacio")]
        public string NomPropietario
        {
            get;
            set;
        }

        [HasMany(Inverse=true)]
        public IList<Multa> Multas
        {
            get { return multas; }
            set { multas = value; }
        }

        [HasMany(Inverse = true)]
        public IList<OrdAprehension> OrdsAprehension
        {
            get { return ordsAprehension; }
            set { ordsAprehension = value; }
        }
    }
}
