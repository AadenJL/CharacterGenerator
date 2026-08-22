String first_name;
String last_name;
int age;
String gender;
String title;
String location;
String trait_1 = "";
String trait_2 = "";
String trait_3 = "";
int military;
int learning;
int diplomacy;
int wealth;

String[] male_first_name_list = ["Edward", "William", "Charles", "George", "Henry", "Richard", "James", "Philip", "Andrew"];
String[] female_first_name_list = ["Matilda", "Anne", "Catherine", "Elizabeth", "Victoria", "Charlotte", "Mary"];
String[] last_name_list = ["Windsor", "Plantagenet", "Tudor", "Hanover", "Stuart", "Capet", "Habsburg"];
String[] gender_list = ["Male", "Female"];
String[] male_title_list = ["Baron", "Viscount", "Count", "Duke", "Prince", "King", "Emperor"];
String[] female_title_list = ["Baroness", "Viscountess", "Countess", "Duchess", "Princess", "Queen", "Empress"];
String[] baron_location_list =
    [
    "Yorkshire", "Kent", "Sussex", "Norfolk", "Suffolk", "Cornwall", "Devon", "Somerset", "Essex", "Cheshire"
    ];
String[] viscount_location_list =
    [
    "Hereford", "Chester", "Stafford", "Worcester", "Durham", "Oxford", "Leicester", "Warwick"
    ];
String[] count_location_list =
    [
    "Anjou", "Flanders", "Champagne", "Provence", "Burgundy", "Toulouse", "Blois"
    ];
String[] duke_location_list =
    [
    "York", "Lancaster", "Norfolk", "Cornwall", "Somerset", "Cambridge", "Gloucester", "Buckingham"
    ];
String[] prince_location_list =
    [
    "Wales", "Scotland", "Normandy", "Aquitaine", "England"
    ];
String[] king_location_list =
    [
    "England", "Scotland", "Ireland", "Great Britain"
    ];
String[] emperor_location_list =
    [
    "the British Empire", "the Holy Roman Empire", "North Sea Empire"
    ];
String[] trait_list =
    [
    "Ambitious", "Shy", "Sadistic", "Brave", "Diligent", "Intelligent", "Gregarious", "Temperate", "Stubborn", "Content", "Decietful", "Greedy",
    "Arrogant", "Wrathful", "Compassionate", "Calm", "Forgiving", "Craven", "Humble", "Just", "Zealous", "Lazy"
    ];

static String pick_random(String[] list)
{
    Random random = new Random();
    int random_index = random.Next(0, list.Length);
    String chosen = list[random_index];
    return chosen;
}

last_name = pick_random(last_name_list);
Random random = new Random();
age = random.Next(16, 100);
gender = pick_random(gender_list);
if (gender == "Male")
{
    title = pick_random(male_title_list);
    first_name = pick_random(male_first_name_list);
}
else
{
    title = pick_random(female_title_list);
    first_name = pick_random(female_first_name_list);
}
switch (title)
{
    case "Baron":
    case "Baroness":
        location = pick_random(baron_location_list);
        wealth = random.Next(0, 25);
        break;
    case "Viscount":
    case "Viscountess":
        location = pick_random(viscount_location_list);
        wealth = random.Next(10, 30);
        break;
    case "Count":
    case "Countess":
        location = pick_random(count_location_list);
        wealth = random.Next(15, 40);
        break;
    case "Duke":
    case "Duchess":
        location = pick_random(duke_location_list);
        wealth = random.Next(25, 55);
        break;
    case "Prince":
    case "Princess":
        location = pick_random(prince_location_list);
        wealth = random.Next(40, 75);
        break;
    case "King":
    case "Queen":
        location = pick_random(king_location_list);
        wealth = random.Next(60, 90);
        break;
    case "Emperor":
    case "Empress":
        location = pick_random(emperor_location_list);
        wealth = random.Next(80, 100);
        break;
    default:
        location = "";
        wealth = 0;
        break;
}

military = random.Next(0, 90);
diplomacy = random.Next(0, 90);
learning = random.Next(0, 90);

trait_1 = pick_random(trait_list);
trait_2 = pick_random(trait_list);
while (trait_1 == trait_2)
{
    trait_2 = pick_random(trait_list);
}
trait_3 = pick_random(trait_list);
while (trait_3 == trait_1 || trait_3 == trait_2)
{
    trait_3 = pick_random(trait_list);
}

String[] traits = [trait_1, trait_2, trait_3];
if (traits.Contains("Ambitious"))
{
    learning += 10;
    diplomacy += 5;
    military += 5;
    wealth += 5;
}
if (traits.Contains("Shy"))
{
    diplomacy -= 10;
    military -= 5;
    learning += 5;
}
if (traits.Contains("Sadistic"))
{
    diplomacy -= 5;
    military += 10;
}
if (traits.Contains("Brave"))
{
    military += 15;
}
if (traits.Contains("Diligent"))
{
    learning += 5;
    diplomacy += 5;
    wealth += 5;
}
if (traits.Contains("Intelligent"))
{
    learning += 15;
    diplomacy += 5;
}
if (traits.Contains("Gregarious"))
{
    diplomacy += 10;
    learning -= 5;
}
if (traits.Contains("Temperate"))
{
    diplomacy += 5;
    learning += 5;
}
if (traits.Contains("Stubborn"))
{
    diplomacy -= 5;
    military -= 5;
    learning += 10;
}
if (traits.Contains("Content"))
{
    diplomacy -= 5;
    learning += 5;
    wealth -= 5;
}
if (traits.Contains("Deceitful"))
{
    diplomacy -= 5;
    military += 10;
}
if (traits.Contains("Greedy"))
{
    diplomacy -= 5;
    military -= 5;
    wealth += 10;
}
if (traits.Contains("Arrogant"))
{
    diplomacy -= 5;
    military += 5;
}
if (traits.Contains("Wrathful"))
{
    diplomacy -= 5;
    military += 10;
}
if (traits.Contains("Compassionate"))
{
    diplomacy += 5;
    learning += 5;
    military -= 10;
}
if (traits.Contains("Calm"))
{
    diplomacy += 5;
    learning += 5;
}
if (traits.Contains("Forgiving"))
{
    learning += 5;
    diplomacy += 5;
}
if (traits.Contains("Craven"))
{
    diplomacy -= 5;
    military -= 10;
    learning += 5;
}
if (traits.Contains("Humble"))
{
    diplomacy += 5;
    military -= 5;
    learning += 5;
}
if (traits.Contains("Just"))
{
    diplomacy += 5;
    learning += 5;
}
if (traits.Contains("Zealous"))
{
    diplomacy -= 5;
    military += 5;
    learning += 5;
}
if (traits.Contains("Lazy"))
{
    diplomacy -= 5;
    military -= 5;
    learning -= 10;
    wealth -= 5;
}

if (diplomacy > 100)
{
    diplomacy = 100;
}
if (military > 100)
{
    military = 100;
}
if (learning > 100)
{
    learning = 100;
}
if (wealth > 100)
{
    wealth = 100;
}
if (diplomacy < 0)
{
    diplomacy = 0;
}
if (military < 0)
{
    military = 0;
}
if (learning < 0)
{
    learning = 0;
}
if (wealth < 0)
{
    wealth = 0;
}

Console.WriteLine("Your character is: ");
Console.WriteLine();
Console.WriteLine(first_name + " " + last_name);
Console.WriteLine(gender + " | " + age + " years old");
Console.WriteLine(title + " of " + location);
Console.WriteLine();
Console.WriteLine("Traits: ");
Console.WriteLine(trait_1);
Console.WriteLine(trait_2);
Console.WriteLine(trait_3);
Console.WriteLine();
Console.WriteLine("Diplomacy: " + diplomacy + "/100");
Console.WriteLine("Military: " + military + "/100");
Console.WriteLine("Learning: " + learning + "/100");
Console.WriteLine("Wealth: " + wealth + "/100");