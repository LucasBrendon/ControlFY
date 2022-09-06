using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFY.Catalogo.Dominio.Enums
{
    public enum ETipoDocumento
    {
        [Description("CPF")]
        CPF = 1,

        [Description("CNPJ")]
        CNPJ = 2
    }
}
