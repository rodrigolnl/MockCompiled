using MockCompiled;
using Mocker;
using Mocker.Enums;

namespace Test
{
    public class Map: BaseMap
    {
        public Map()
        {
            NewRuleSet<PessoaModel>()
                .SetPreset(x => x.Nome, Preset.NomeCompleto)

                .SetRange(x => x.Id, Operator.GreaterThan, 1000)
                .SetRange(x => x.Id, Operator.LesserThan, 2000)

                .SetRange(x => x.Data, Operator.GreaterThan, new DateTime(2023, 1, 1))
                .SetRange(x => x.Data, Operator.LesserThan, new DateTime(2023, 12, 31))
                .SetValue(x => x.Data, x => x.Data.Date)

                .SetRange(x => x.Sexo, Operator.In, new Char[] { 'M', 'F' })
                .SetValueOnConditional(x => x.DescricaoSexo, If.True, x => x.Sexo == 'M', "Masculino")
                .SetValueOnConditional(x => x.DescricaoSexo, If.True, x => x.Sexo == 'F', "Feminino");
                
                //.SetRange(x => x.Contratos, Operator.LesserThan, 10);         DOESN'T WORK YET
        }
    }
}
