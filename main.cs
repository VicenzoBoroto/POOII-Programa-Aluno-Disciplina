using System;

class Disciplina
{
  public string nomeDisciplina { get; set; }
  public int cargaHoraria { get; set; }

  public Disciplina(string nome, int carga)
  {
    nomeDisciplina = nome;
    cargaHoraria = carga;
  }
}

class Aluno
{
  public string nome { get; set; }
  public double nota1 { get; set; }
  public double nota2 { get; set; }
  public double media { get; set; }
  public int faltas { get; set; }
  public string status { get; set; }
  public bool isSemestreFinalizado { get; set; }
    

  public Aluno(string nomeAluno)
  {
    nome = nomeAluno;
    faltas = 0;
  }

  public double AtribuirNota1(double nota1Aluno)
  {
    nota1 = nota1Aluno;
    return nota1;
  }

  public double AtribuirNota2(double nota2Aluno)
  {
    nota2 = nota2Aluno;
    return nota2;
  }

  public void CalcularMedia()
  {
     media = (nota1 + nota2) / 2;
  }

  public void AtribuirFalta(int falta)
  {
     faltas += falta;
  }

  public void AbonarFalta(int abonar)
  {
     faltas -= abonar;
  }

  public void VerificarStatus(int cargaHoraria, string nomeDisciplina, string nome)
  {
     if(faltas <= (0.25 * cargaHoraria) && media >= 7){
       status = "Aprovado";
     } else {
       status = "Reprovado";
     }
    Console.WriteLine($"O aluno {nome} está {status} na disciplina {nomeDisciplina}.");
  }
}

class Program
{
  static void Main(string[] args)
  {
    Disciplina disciplina = new Disciplina("Matemática", 60);

    Aluno aluno = new Aluno("João");
    aluno.AtribuirNota1(8.5);
    aluno.AtribuirNota2(2.0);
    aluno.CalcularMedia();
    aluno.AtribuirFalta(10);
    aluno.AbonarFalta(1);

    aluno.VerificarStatus(disciplina.cargaHoraria, disciplina.nomeDisciplina, aluno.nome);

    Console.WriteLine($"Nome do aluno: {aluno.nome}");
    Console.WriteLine($"Média: {aluno.media}");
    Console.WriteLine($"Faltas: {aluno.faltas}");
    Console.WriteLine($"Status: {aluno.status}");
  }
}
