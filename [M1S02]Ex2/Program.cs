using Ex2;

FichaInscrição inscrição = new FichaInscrição()

{
    id = 52,
    nome = "Marcelo",
    dataNascimento = DateTime.Parse("15/03/1971"),
    menorIdade = true
};

inscrição.ImprimeInscrição();
