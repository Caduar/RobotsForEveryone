using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Activities;
using System.ComponentModel;

namespace FirstCustomActivity
{
    public class SumarNumeros : CodeActivity
    {
        [Category ("Input")]
        public InArgument<int> PrimerNumero { get; set; }

        [Category("Input")]
        public InArgument<int> SegundoNumero { get; set; }

        [Category("Output")]
        public OutArgument<int> Resultado{ get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            var FN = PrimerNumero.Get(context);
            var SN = SegundoNumero.Get(context);
            var Res = FN + SN;

            Resultado.Set(context, Res);
        }
    }
}
