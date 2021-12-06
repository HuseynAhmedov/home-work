let applyBtn = document.getElementById('ApplyBtn');

applyBtn.addEventListener('click',applyChanges)

function applyChanges ()
{
    let fontSizePx = document.getElementById('FontSize').value
    let colorCode = document.getElementById('ColorPicker').value
    let allCardTexts = document.getElementsByClassName('card-text')
    for (let index = 0; index < allCardTexts.length; index++) 
    {
        
        allCardTexts[index].style.color = colorCode;
        allCardTexts[index].style.fontSize = fontSizePx + "px"
    }
}