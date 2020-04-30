using Naive_bayesML.Model;
using System;

namespace naive_bayes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add input data
            var input = new ModelInput();
            Console.WriteLine("Escriba un comentario: ");
            //input.Comentario = "comerciantes en las calles";
            input.Comentario = Console.ReadLine();
            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);
            Console.WriteLine($"Text: {input.Comentario}\nPertenece a la Categoria: {result.Prediction}\nScore {String.Join(", ", result.Score)}");
        }
    }
}
