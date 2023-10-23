using MockCompiled;
using Mocker;
using Test;

var generator = new Generator(new Map());

var pessoa = generator.Generate<PessoaModel>();
var pessoas = generator.GenerateList<PessoaModel>();
Console.WriteLine(pessoa.Sexo);