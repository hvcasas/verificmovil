using System;
using System.Collections.Generic;
using System.Text;
using Castle.ActiveRecord;
using Castle.Components.Validator;

namespace MovilDomain
{
    [ActiveRecord(Table = "Licencias")]
    public class Licencia : ActiveRecordValidationBase<Licencia>
    {
        private IList<Multa> multas = new List<Multa>();
        private IList<OrdAprehension> ordsAprehension = new List<OrdAprehension>();

        public Licencia()
        {
        }

        [PrimaryKey(PrimaryKeyType.Native)]
        public int Id
        {
            get;
            set;
        }

        [Property(NotNull = true)]
        [ValidateNonEmpty("No debe estar Vacio")]
        public int NoLicencia
        {
            get;
            set;
        }

        [Property(NotNull = true)]
        [ValidateNonEmpty("No debe estar Vacio")]
        public string Foto
        {
            get;
            set;
        }

        [Property(NotNull = true, Length = 50)]
        [ValidateNonEmpty("No debe estar Vacio")]
        public string Nombres
        {
            get;
            set;
        }

        [Property(NotNull = true, Length = 30)]
        [ValidateNonEmpty("No debe estar Vacio")]
        public string ApPaterno
        {
            get;
            set;
        }

        [Property(NotNull = true, Length = 30)]
        [ValidateNonEmpty("No debe estar Vacio")]
        public string ApMaterno
        {
            get;
            set;
        }

        [Property(NotNull = true, Length = 13)]
        [ValidateNonEmpty("No debe estar Vacio")]
        public string Rfc
        {
            get;
            set;
        }

        [Property(NotNull = true)]
        [ValidateNonEmpty("No debe estar Vacio")]
        public DateTime FecExpedicion
        {
            get;
            set;
        }

        [Property(NotNull = true)]
        [ValidateNonEmpty("No debe estar Vacio")]
        public DateTime FecVencimiento
        {
            get;
            set;
        }

        [Property(NotNull = true, Length = 20)]
        [ValidateNonEmpty("No debe estar Vacio")]
        public string Estatura
        {
            get;
            set;
        }

        [Property(NotNull = true, Length = 30)]
        [ValidateNonEmpty("No debe estar Vacio")]
        public string TipoCabello
        {
            get;
            set;
        }

        [Property(NotNull = true, Length = 20)]
        [ValidateNonEmpty("No debe estar Vacio")]
        public string ColorOjos
        {
            get;
            set;
        }

        [Property(NotNull = true, Length = 20)]
        [ValidateNonEmpty("No debe estar Vacio")]
        public string TipoSangre
        {
            get;
            set;
        }

        [Property(NotNull = true, Length = 100)]
        [ValidateNonEmpty("No debe estar Vacio")]
        public string SeñasPartic
        {
            get;
            set;
        }

        [Property(NotNull = true, Length = 20)]
        [ValidateNonEmpty("No debe estar Vacio")]
        public string Nacionalidad
        {
            get;
            set;
        }

        [Property(NotNull = true, Length = 50)]
        [ValidateNonEmpty("No debe estar Vacio")]
        public string ReqEspeciales
        {
            get;
            set;
        }

        [Property(NotNull = true, Length = 150)]
        [ValidateNonEmpty("No debe estar Vacio")]
        public string AccidenteObs
        {
            get;
            set;
        }

        [BelongsTo("DireccionId", NotNull = true)]
        public Direccion direccion
        {
            get;
            set;
        }

        [HasMany(Inverse = true)]
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
