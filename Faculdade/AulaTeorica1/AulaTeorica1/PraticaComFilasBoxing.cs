using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaTeorica2
{
    class PraticaComFilasBoxing
    {
        public void ExercicioBoxingFilas()
        {
            var filaGenerics = new FilaGenerics<Animal>(10);
            var filaObject = new FilaObject(10);

            var cachorro1 = new Cachorro();
            Animal cachorro2 = new Cachorro();
            IBarulhento cachorro3 = new Cachorro();

            var gato1 = new Gato();
            Animal gato2 = new Gato();
            IBarulhento gato3 = new Gato();

            filaGenerics.Enqueue(cachorro1);
            filaGenerics.Enqueue(gato1);
            filaGenerics.Enqueue(cachorro2);
            filaGenerics.Enqueue(gato2);
            filaGenerics.Enqueue((Animal)cachorro3); 
            // Precisar fazer um casting dizendo que é um tipo Animal
            filaGenerics.Enqueue((Animal)gato3);

            filaObject.Enqueue(cachorro1);
            filaObject.Enqueue(gato1);
            filaObject.Enqueue(cachorro2);
            filaObject.Enqueue(gato2);
            filaObject.Enqueue(cachorro3);
            filaObject.Enqueue(gato3);
            try
            {
                while(filaGenerics.Count > 0)
                {
                    IBarulhento animal = filaGenerics.Dequeue();
                    Console.WriteLine($"O Type é {animal.GetType().BaseType.Name} " +
                                      $"Sou um {animal.GetType().Name} " +
                                      $"Emito o seguinte som {animal.EmetirSom()}");
                }
                while (filaObject.Count > 0)
                {
                    IBarulhento animal = (Animal)filaObject.Dequeue();
                    Console.WriteLine($"O Type é {animal.GetType().BaseType.Name} " +
                                      $"Sou um {animal.GetType().Name} " +
                                      $"Emito o seguinte som {animal.EmetirSom()}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao realizar unboxing de um type.Erro: {ex.Message}");
            }
        }
    }
}
