let num = 4567
console.log(20)
console.log(ReverseStartAndEndNums(num))

function ReverseStartAndEndNums (numMain)
{
    let tempnum = numMain.toString()
    return tempnum[tempnum.length-1] + tempnum.substring(1 , tempnum.length-1) + tempnum[0]
}


// ---------------------------------------

let num2 = 2
console.log(PowerOf(num2,3))

function PowerOf (numMain , powerOfnum)
{
    let tempnum = 1;
    for (let index = 0; index < powerOfnum; index++) 
    {
        tempnum *= numMain
    }
    return tempnum
}

//-----------------------------------------

let array = [23 , true , NaN , 45 , "this doesnt make sence " , 45]
indexOf45(array)

function indexOf45 (arrayMain)
{
    for (let index = 0; index < arrayMain.length; index++) 
    {
        if (arrayMain[index] == 45 ) 
        {
            return console.log(index)
        }
    }

    //return console.log(arrayMain.indexOf(45)) 
}