var myNodelist = document.getElementsByTagName("LI");
var addBtn = document.getElementsByClassName("BtnAdd")
var i;
for (i = 0; i < myNodelist.length; i++) {
  var span = document.createElement("SPAN");
  var txt = document.createTextNode("x");
  span.className = "close";
  span.appendChild(txt);
  myNodelist[i].appendChild(span);
}


var close = document.getElementsByClassName("close");
var i;
for (i = 0; i < close.length; i++) {
  close[i].onclick = function() {
    var div = this.parentElement;
    div.style.display = "none";
  }
}


var list = document.querySelector('ul');
list.addEventListener('click', function(ev) {
  if (ev.target.tagName === 'LI') 
  {
    ev.target.classList.toggle('list-done');
  }
}, false);

addBtn[0].addEventListener("click", newElement)

function newElement() 
{
  var li = document.createElement("li");
  var inputValue = document.getElementById("FormInput").value;
  var t = document.createTextNode(inputValue);
  li.appendChild(t);
  if (inputValue === '') 
  {
    alert("to do list name cannot be emty");
  } else 
  {
    document.getElementById("DoList").appendChild(li);
  }
  document.getElementById("FormInput").value = "";

  var span = document.createElement("SPAN");
  var txt = document.createTextNode("x");
  span.className = "close";
  span.appendChild(txt);
  li.appendChild(span);

  for (i = 0; i < close.length; i++) 
  {
    close[i].onclick = function() 
    {
      var div = this.parentElement;
      div.style.display = "none";
    }
  }
}