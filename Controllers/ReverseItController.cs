using Microsoft.AspNetCore.Mvc;

namespace GoodwinR_ReverseItEndPoint.Controllers;

[ApiController]
[Route("[controller]")]
public class ReverseController : ControllerBase
{
[HttpGet]
[Route("{num1}/{word}")]
public string rev(string num1,string word){
bool isNumber;
bool isWord;
long validNum = 0;
isNumber = Int64.TryParse(num1, out validNum);
isWord = Int64.TryParse(word, out validNum);

if(isNumber == true && isWord == false){
   string lol = String.Empty;
            for (int i = num1.Length - 1; i > -1; i--)
            {
               lol += num1[i];
               
            };
            var resultstring = new string(word.ToCharArray().Reverse().ToArray());
return $"{num1} reversed is {lol}\n{word} reversed is {resultstring}!!";
}else{
    return "Please enter a valid Number and Word (in that order!)";
}
}



}
