using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class ListaDePessoas
    {
        List<Pessoa> pessoas = new List<Pessoa>()
        {
                new Pessoa(1, "Darley", 'M', new DateTime(1998, 3, 21), 1.73, "Engenharia de Software"),
                new Pessoa(2, "Ana",'F', new DateTime(1987, 3, 4), 1.70, "Engenharia Aeroespacial"),
                new Pessoa(3, "Maria", 'F', new DateTime(1998, 4, 3), 1.65, "Medicina"),
                new Pessoa(4, "Joao", 'M', new DateTime(2002, 5, 30), 1.80, "Física"),
                new Pessoa(5, "John", 'M', new DateTime(2001, 3, 3), 1.92, "Educação Física"),
                new Pessoa(6, "Harry", 'M', new DateTime(1995, 12, 12), 1.72, "Química"),
                new Pessoa(7, "Malorie", 'F', new DateTime(1977, 7, 7), 1.74, "Engenharia da Computação"),
                new Pessoa(8, "Michael", 'M', new DateTime(1990, 3, 8), 1.69, "ADS"),
                new Pessoa(9, "Sofia", 'F', new DateTime(1996, 3, 11), 1.52, "Ciência da Computação"),
                new Pessoa(10, "Hillary", 'F', new DateTime(2003, 5, 10), 1.65, "Engenharia de Software"),
                new Pessoa(11, "Yanker", 'M', new DateTime(1984, 7, 5), 2.0, "Engenharia Elétrica"),
                new Pessoa(12, "Carl", 'M', new DateTime(1986, 3, 28), 1.95, "Engenharia Florestal"),
                new Pessoa(13, "Emelly", 'F', new DateTime(2005, 12, 12), 1.82, "Engenharia Eletrônica"),
                new Pessoa(14, "Jay", 'F', new DateTime(2006, 6, 6), 1.74, "Engenharia de Machine Learning"),
        };
    }
}
