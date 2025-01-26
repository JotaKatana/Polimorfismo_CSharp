namespace Polimorfismo
{
	class Program
	{
		static void Main(string[] args)
		{
			Animal[] animais = new Animal[3]; // Vetor de Animais

			animais[0] = new Ave("pardal");
            animais[1] = new Macaco("gorila");
            animais[2] = new Peixe("espada");

			foreach(Animal a in animais) // Para cada animal que tiver no meu vetor animais
			{
				MoverAnimal(a);          // Vou mover o animal "a"
			}
            Console.ReadKey();           // Para ver oresultado na tela

        }

		public static void MoverAnimal(Animal animal) // Recebe no parametro um "Obj Type Animal"
// Ele faz uma verificações de TIPOS, para ver como esse animal está andando
		{
            //if (animal.Tipo == "Peixe")
            //{
            //	Console.WriteLine("Peixe nadando...");
            //}
            //else if (animal.Tipo == "Macaco...")
            //{
            //	Console.WriteLine("Macaco andando...");
            //}
            //else
            //{
            //  Console.WriteLine("Ave voando...");
            //}
											//Quando eu chamar o mover animal
            Console.WriteLine(animal.Tipo); //Imprime o tipo do animal
			animal.Mover();					//E o texto de movimento do animal
		}

	}
//---------------------------------------------------------------------------------------      PODERIA TER DEITO EM ARQ SEPARADOS


    public class Animal                         //Classe
		{
			public string Tipo { get; set; }    //Propriedade

			public Animal(string tipo)          //Construtor
			{ 
				Tipo = tipo;                    //Valor que vai destinar a Var Tipo
			}

// Esse metodo virtual num classe base significa que eu posso sobescrita desse metodo nas minhas classes que herdei ....
// .... Posso subistituir a implemetação que eu tenho na minha classe base por uma da minha classe filha
				public virtual void Mover()    //--- Metodo Virtual --- POLI  "Meio que é uma var que posso usar valores das outras classes"
				{
				
				}
		}

    //-------------------------------------------------------------------------------------      PODERIA TER DEITO EM ARQ SEPARADOS

    public class Peixe : Animal                //--- Classe --- HERANÇA
							// IMPORTANT = Como eu tenho um construtor na Classe herdada eu preciso ter um equivalente nesse tbm.
    {
        // Quando falo base -> Falo com o herança pai, preciso passar pra minha classe base aquele tipo de contrutor da minha classe especifica
        public Peixe(string tipoAnimal) : base(tipoAnimal) //tipoAnimal to passando pra minha classe base
        { 
		
		}
		// Override = Sobre escrever, então ele sobre escreve o meu public virtual MOVER.
		public override void Mover()
		{
			Console.WriteLine("Nadar 10 metros");
		}

	}

    //-------------------------------------------------------------------------------------      PODERIA TER DEITO EM ARQ SEPARADOS
    public class Macaco : Animal
	{
		public Macaco(string tipoAnimal) : base(tipoAnimal)
		{

		}

		public override void Mover()
		{
            Console.WriteLine("Andar 10 metros");
		}
	}

    //-------------------------------------------------------------------------------------      PODERIA TER DEITO EM ARQ SEPARADOS
    public class Ave : Animal
	{
		public Ave(string tipoAnimal) : base(tipoAnimal)
		{

		}

        public override void Mover()
        {
            Console.WriteLine("Voar 10 metros");
		}
    }
}


