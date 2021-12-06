let AddBtn = document.getElementById('AddBtn')

AddBtn.addEventListener('click', chkInput)

function chkInput()
{
    chkName()
    chkAge()
}

function chkName()
{
    let chkText = document.getElementById('NameChkText')
    let chk = document.getElementById("NameChk");
    let FullnameInput = document.getElementById('FullNameInput').value
    let fixedName = FullnameInput.trim()
    let stringArr = fixedName.split(" ")
    if (stringArr.length === 2) 
    {
        chkText.classList.remove('visible-text')
        chk.classList.remove('check-false')
        chk.classList.add('check-true')
        
        return true
    }
    else
    {
        chkText.classList.add('visible-text')
        chk.classList.remove('check-true')
        chk.classList.add('check-false')
        return false;
    }
}

function chkAge()
{
    let chkText = document.getElementById('AgeChkText')
    let ageInput = document.getElementById('AgeInput').value
    let chk = document.getElementById('AgeChk');

    if (ageInput > 0 && ageInput < 100) 
    {
        chkText.classList.remove('visible-text')
        chk.classList.remove('check-false')
        chk.classList.add('check-true')
        return true
    }
    else
    {
        chkText.classList.add('visible-text')
        chk.classList.remove('check-true')
        chk.classList.add('check-false')
        return false;
    }
}


