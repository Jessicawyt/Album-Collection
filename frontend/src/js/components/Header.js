
const contentDiv = document.getElementById("app");


export default {
    SetupNavBar,
    SetupEventListeners
}


function SetupNavBar(){
    return `
        <h1 class = "header">Spring 2022 C# Music</h1>
        <ul>
            <li id='navArtist' class = "nav1">Artist</li>
            <li id='navAlbums' class = "nav2">Albums</li>
        </ul>
        
    `;
}


function SetupEventListeners(){
    let navArtist = document.getElementById('navArtist');
    let navAlbums = document.getElementById('navAlbums');
    navAlbums.addEventListener('click', function(){
        contentDiv.innerHTML = 'h';
    });
    navArtist.addEventListener('click', function(){
        contentDiv.innerHTML = 'c';
    });
}