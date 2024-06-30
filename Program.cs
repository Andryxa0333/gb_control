// Шаг первый
string[] input = new string[4] {"Hello", "2", "world", ":-)"};
string[] output = new string[input.Length];
int elemCount = 0;

// Шаг второй
for (int i = 0; i < input.Length; i++){
    if (input[i].Length <= 3){
        output[elemCount] = input[i];
        elemCount++;
    }
}

// Шаг третий
for (int i = 0; i < elemCount; i++){
    Console.Write("{0} ",output[i]);
}