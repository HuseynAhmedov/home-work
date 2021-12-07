let mineLayer = document.getElementById('MineLayer')
let playZone = document.getElementById('PlayZone')


window.addEventListener('keydown', function(e)
{
    console.log(mineLayer.offsetTop)
    console.log(mineLayer.offsetLeft)
    let topGap = mineLayer.offsetTop
    let leftGap = mineLayer.offsetLeft
    if (e.keyCode == 68 && leftGap < 359 ) 
    {
        leftGap+=2
        mineLayer.style.left = leftGap + "px"
    }
    if (e.keyCode == 65 && leftGap > 0) 
    {
        leftGap-=2
        mineLayer.style.left = leftGap + "px"
    }
    if (e.keyCode == 87 && topGap > 0 ) 
    {
        topGap-=2
        mineLayer.style.top = topGap + "px"
    }
    if (e.keyCode == 83 && topGap < 359) 
    {
        topGap+=2
        mineLayer.style.top = topGap + "px"
    }
    if (e.keyCode == 13 ) 
    {
        var newMine = document.createElement('span')
        newMine.classList.add('naval-mine')
        newMine.style.left = (mineLayer.offsetLeft + 11) + "px"
        newMine.style.top = (mineLayer.offsetTop + 11)+ "px"
        playZone.appendChild(newMine)
    }
})