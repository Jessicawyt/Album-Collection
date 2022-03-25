const contentDiv = document.getElementById("app");
import requestHandler from "../../requestHandler";
import { ALBUM_CONTROLLER } from "../constants";

export default{
    GetAlbum,
}

function GetAlbum(id){
    console.log('test',id);
    requestHandler.allRequest(ALBUM_CONTROLLER + id, Process);
    
    // fetch(AlbumAPIURL + id)//need to reference ALBUM_CONTROLLER after we pushed SONG/REVIEW
    // .then(response => response.json())
    // .then(data => process(data))
    // .catch(err => console.log(err))   
}

function Edit(Album){
    console.log("works");
    contentDiv.innerHTML = `

    <h2>Album Detail </h2>
    <input type="hidden" value="${Album.id}" id="EditId" />
    <input type="hidden" value="${Album.artistId}" id="EditArtistId" />

    <section class="form">
        <input id="EditTitle" placeholder="Title" value="${Album.title}" />
        <input value="${Album.image}" placeholder="ImageUrl" id="EditImage" />
        <input id="EditRecordLabel" placeholder="Record Label" value="${Album.recordLabel}"/>
        <button id="${Album.id}" class="UpdateButton" >Update</button>
    </section>
    
    `;
    //addEventListeners();
    let UpdateButton = document.getElementsByClassName("UpdateButton")[0];

    UpdateButton.addEventListener('click', function(){

       let EditAlbum = {
         Id: document.getElementById("EditId").value,
         Image: document.getElementById("EditImage").value,
         ArtistId: document.getElementById("EditArtistId").value,
         Title: document.getElementById("EditTitle").value,
         RecordLabel: document.getElementById("EditRecordLabel").value
       }

       requestHandler.allRequest(ALBUM_CONTROLLER, Process, "PUT", EditAlbum);

    })

  

}



function Process(album){
    console.log(album);
    contentDiv.innerHTML = `
        ${album.title}
        <section class="parent">
            <div class="div1"><img src=${album.image} /></div>
            <div class="div2">
                <h2>${album.artist.name}</h3>
                <h1>${album.title}</h1>
                <h3>${album.recordLabel}</h3>
            </div>
            <div class="div3">
            <ul>
                    
           
                ${album.songs.map(song => {
                    return `
                   <li>
                   ${song.title}
                   </li>
                    `
                })}
                </ul>
            </div>
            <div class="div4">

            <ul>
                ${album.reviews.map(review => {
                    return `
                    <li>
                    <p>${review.content}</p>
                   <h2> ${review.reviewerName}</h2>
                    </li>

                    `
                })}
                </ul>
            </div>
            
        </section>
        <button id=${album.id} class="editButton">Edit</button>
    `;
    addEventListeners();
}

function addEventListeners(){
    let editButton = document.getElementsByClassName('editButton')[0];
    editButton.addEventListener('click', function(){
        requestHandler.allRequest(ALBUM_CONTROLLER + this.id, data => {
            Edit(data);
            
        })
    });
}