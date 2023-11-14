
List<String> personas = new List<string>();
List<String> personas2 = new List<string>()
{
    "Persona 1", "Persona 2", "Persona 3"
};
personas2.Add("Persona 4");

personas.Add("Roger");
personas.Add("Axel");
personas.Add("Gaspar");
personas.Add("Jason");
personas.Add("Alba");
personas.Add("Roger");
personas.Add("1");
personas.Add("2");
personas.Add("10");
//personas.Insert(0, "Pepe");

//personas.Remove(personas[0]);
//personas.Remove("Alba");
//personas.RemoveAt(0);
//personas.RemoveAll(persona => persona == "Roger");
//personas.Clear();

personas.Sort();

foreach (var persona in personas2)
{
    Console.WriteLine(persona);
}

List<int> valores = new List<int>();
valores.Add(1);
valores.Add(2);
valores.Add(3);
valores.Add(4);
valores.Add(5);
valores.Add(6);
valores.Add(7);
valores.Add(8);
valores.Add(9);
valores.Add(10);

foreach (var valor in valores)
{
    Console.WriteLine(valor);
}

Dictionary<string, string> data = new Dictionary<string, string>()
{
    {"Pais", "Honduras"}, 
    {"Departamento", "Cortes"}
};
data.Add("Municipio", "Villanueva");

data.Remove("Pais");
data["Pais"] = "Honduras";
data["Departamento"] = "Francisco Morazan";

if (data.TryGetValue("Aldea", out string? res))
{
    Console.WriteLine(res);
} else
{
    Console.WriteLine("El parametro no existe");
}

//data.Clear();
foreach (var dato in data)
{
    Console.WriteLine($"Key: {dato.Key}, Value: {dato.Value}");
}