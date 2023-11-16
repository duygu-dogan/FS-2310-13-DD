"use strict"; //stricts some coding rules, e.g. don't allow you to use variables without defining them


let students = ["ayşen", "umay", "ceyda", "begüm", "köfte", "heda"];
let result;

result = students.length;
result = students; //can be transferred to another variable
result = students.toString(); //Returns a string representation of an array
result = students.join(";"); //Adds all the elements of an array into a string, separated by the specified separator string.
result = result.split(";"); //string method, Split a string into substrings using the specified separator and return them as an array.


let products1 =["Ürün1", "Ürün2", "Ürün3"];
let products2 = ["Ürün4", "Ürün5", "Ürün6"];

result = products1.concat(products2); //combines two or more arrays and  returns a new array without modifying any existing arrays.

students.push("Zeynep"); //Appends new elements to the end of an array, and returns the new length of the array.
students.pop(); //Removes the last element from an array and returns it.
students.shift();//Removes the first element from an array and returns it.
students.unshift("Ece"); //Inserts new elements at the start of an array, and returns the new length of the array.
students[1]="Haydar"; //we can reach any element of an array and replace it, similar to string because it is a char array.

//students dizisindeki 'ceyda' değerini taşıyan elemanın içeriğini ece olarak değiştirin.

result = students.indexOf("ceyda");
students[2] = "ece";//students[students.indexOf("ceyda")] = "ece";

result = students.splice(students.indexOf("ece"), 1); //Removes elements from an array and, if necessary, inserts new elements in their place, returning the deleted elements.
result = students.splice(2,2); //removes two elements beginning from index 2


result = students;




console.log(result);