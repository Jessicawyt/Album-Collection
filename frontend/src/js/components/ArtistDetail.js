import AllRequest from "../../requestHandler";
import { ARTIST_CONTROLLER } from "../constants";
import { appDiv } from "../constants";

export default{
    GetArtist
}

function GetArtist(artistId){
    AllRequest.allRequest(ARTIST_CONTROLLER + artistId,Process);

}


function Process(artist){
    if (artist.albums == undefined) {
        artist.albums = [];
    }

    appDiv.innerHTML =`
        <section>
            <button id="updateArtistBtn">Edit Artist</button>
            <p>${artist.name}</p>
            <p>${artist.genre}</p>
            <p>${artist.bio}</p>
            <img src="${artist.heroImage}">
          
            <div>
                ${artist.albums.map(album =>{
                    return`
                        <p>${album.title}</p>
                        <img src="${album.image}">
                    `
                }).join('')}
            </div>
        
        </section> 
    `;
    AddEventListeners(artist);
}

function AddEventListeners(artist){
    let updateArtistBtn = document.getElementById('updateArtistBtn');
    updateArtistBtn.addEventListener('click',function(){
    RenderUpdateArtistView(artist);
    });
}

function RenderUpdateArtistView(artist){
    appDiv.innerHTML = `
        <h2>Edit Artist</h2>
        <section class="form">
            <input type="hidden" value="${artist.id}" id="updateArtistId" />
            <input type="text" placeholder="Name" id="artistName" value="${artist.name}">
            <input type="text" placeholder="Genre" id="artistGenre" value="${artist.genre}">
            <input type="text" placeholder="artistBio" id="artistBio" value="${artist.bio}">
            <input type="text" placeholder="Image Url" id="artistImage" value="${artist.image}">

            <button id="saveUpdateArtistBtn">Save</button>
        </section>
    `;

    let saveUpdateArtistBtn = document.getElementById('saveUpdateArtistBtn');
    saveUpdateArtistBtn.addEventListener('click',function(){
        
        UpdateArtist(artist.id);
        
    });
}


function UpdateArtist(id){
    let artistName = document.getElementById('artistName').value;
    let artistGenre = document.getElementById('artistGenre').value;
    let artistBio = document.getElementById('artistBio').value;
    let artistImage = document.getElementById('artistImage').value;

    let updatedArtist = {
        Id: id,
        Name: artistName,
        Genre: artistGenre,
        Bio: artistBio,
        HeroImage: artistImage
    }

    console.log(updatedArtist);

    AllRequest.allRequest(ARTIST_CONTROLLER,Process,"PUT",updatedArtist);
  
}
