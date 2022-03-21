const contentDiv = document.getElementById("app");


export default {
    GetAlbum
}

function GetAlbum(){
    fetch(CONSTANTS.AlbumAPIURL)
    .then(response => response.json())
    .then(data => {
        contentDiv.innerHTML = Process(data);
    })
    .catch(err => console.log(err));
}

function Process(Album){
    return `
        <ol>
            ${Album.map(album =>{
                return `
                    <li>
                        ${Album.title}
                        <ul>
                            <li>Artist: ${Album.Artist.Name}</li>
                            <li>Description: ${Album.RecordLabel}</li>
                            <li>Image: ${Album.Image}</li>
                        </ul>
                    </li>
                `;
            }).join('')}
        </ol>
    `;
}

