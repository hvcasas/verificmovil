using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.ActiveRecord;
using Castle.Components.Validator;

namespace MovilDomain
{
    [ActiveRecord(Table = "OrdsAprehension")]
    public class OrdAprehension : ActiveRecordValidationBase<OrdAprehension>
    {
        OrdAprehension()
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
        public string Foto
        {
            get;
            set;
        }

        [Property(NotNull = true, Length = 100)]
        [ValidateNonEmpty("No debe estar Vacio")]
        public string Motivo
        {
            get;
            set;
        }

        [Property(NotNull = true)]
        [ValidateNonEmpty("No debe estar Vacio")]
        public DateTime FecOrden
        {
            get;
            set;
        }
        
        [Property(NotNull = true)]
        [ValidateNonEmpty("No debe estar Vacio")]
        public bool StatusOrden
        {
            get;
            set;
        }

        [Property(NotNull = true, Length = 30)]
        [ValidateNonEmpty("No debe estar Vacio")]
        public string ReqPor
        {
            get;
            set;
        }

        [Property(NotNull = true, Length = 30)]
        [ValidateNonEmpty("No debe estar Vacio")]
        public string Nombre
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

        [BelongsTo("DireccionId", NotNull = true)]
        public Direccion direccion
        {
            get;
            set;
        }

        [BelongsTo("PlacaId",NotNull=true)]
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
