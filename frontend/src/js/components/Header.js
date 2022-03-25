import { GetArtists } from "./ArtistIndex";
import albumActions from "./albumActions"


const contentDiv = document.getElementById("app");

export default {
    SetupNavBar,
    SetupEventListeners
}


function SetupNavBar(){
    return `
        <div class="nav-item" id="nav-artists">
            <div class="nav-icon-container">
                <img class="nav-icon" src="./static/artist-icon.svg"/>
            </div>
            <div class="nav-icon-label">
                Artists
            </div>
        </div>
        <div class="nav-item" id="nav-albums">
            <div class="nav-icon-container">
                <img class="nav-icon" src="./static/album-icon.svg"/>
            </div>
            <div class="nav-icon-label">
                Albums
            </div>
        </div>
        <div class="nav-item" id="nav-songs">
            <div class="nav-icon-container">
                <img class="nav-icon" src="./static/song-icon.svg"/>
            </div>
            <div class="nav-icon-label">
                Songs
            </div>
        </div>
        <div class="nav-item" id="nav-artists">
            <div class="nav-icon-container">
                <img class="nav-icon" src="./static/review-icon.svg"/>
            </div>
            <div class="nav-icon-label">
                Reviews
            </div>
        </div>
    `;
}


function SetupEventListeners(){
    let navArtist = document.getElementById('nav-artists');
    let navAlbums = document.getElementById('nav-albums');
    navAlbums.addEventListener('click', function(){
        albumActions.GetAlbums();    
    });
    navArtist.addEventListener('click', function(){   
        GetArtists();
        
    });
}