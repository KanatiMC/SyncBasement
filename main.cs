using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {
		bool loopedBool = true;
		Console.WriteLine(SyncBasement);
		while (loopedBool == true){
			Console.WriteLine("Pick A Name To Select:\n1. CJ");
			string person = Console.ReadLine();
			string selectedPerson = person.ToLower();
			if (selectedPerson != "cj"){
				Console.WriteLine("Please Choose A Correct Name!");
				loopedBool = true;
			}
			if (selectedPerson == "cj"){
				Console.WriteLine("Pick An Action Number:\n1. Whip\n2. Yell At");
				int action = int.Parse(Console.ReadLine());
				if (action == 1){
					Console.WriteLine(selectedPerson.ToUpper()+" Was Whipped!");
				}
				if (action == 2){
					Console.WriteLine(germanPhrases[Program.randomNum(1)]);
				}
				loopedBool = false;
			}
		}
  }
	private static string[] germanPhrases = new string[]{
		"FUR DAS VATERLAND JAAAA",
		"DU BIST EIN HURENSOHN",
		"ICH WERDE DICH FICKEN"
	};
	private static string SyncBasement = String.Concat(new string[]{
		@"  _________                     __________                                             __   ",
		"\n",
		@" /   _____/__.__. ____   ____   \______   \_____    ______ ____   _____   ____   _____/  |_ ",
		"\n",
		@" \_____  <   |  |/    \_/ ___\   |    |  _/\__  \  /  ___// __ \ /     \_/ __ \ /    \   __\",
		"\n",
		@" /        \___  |   |  \  \___   |    |   \ / __ \_\___ \\  ___/|  Y Y  \  ___/|   |  \  |  ",
		"\n",
		@"/_______  / ____|___|  /\___  >  |______  /(____  /____  >\___  >__|_|  /\___  >___|  /__|  ",
		"\n",
		@"        \/\/         \/     \/          \/      \/     \/     \/      \/     \/     \/      "
	});									

	public static int randomNum(int length)
  {
    const string chars = "012";
    return int.Parse(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
  }
    private static Random random = new Random();
}