# Album Collection
## Scenario
Our super hip ironic friend needs an easy way to curate soundscapes for the Italian scooter/coffee hybrid co-op startup at which they volunteer (they also fix old polaroid cameras).

They have tasked us with creating an application that can easily keep track of their EXTENSIVE record collection and access music by artists or albums. This collection is in a constant state of flux, so it is essential for the users to be able to update the collection and it's elements.

## Requirements
We are going to create an API using ASP.Net Entity Framework that will handle our DB and interactions with it.
- Create a RESTful API with ASP.Net
- Endpoints for the following:
   - All CRUD operations for artists
      - Create endpoint
      - Read endpoint
      - Update endpoint
      - Delete endpoint
   - All CRUD operations for albums
      - Create endpoint
      - Read endpoint
      - Update endpoint
      - Delete endpoint
- A database service layer for retrieving and storing artists, albums, and songs from the database and interacting with the controllers.

## Relationships
Our user should be able to:
- access albums from the artist that made them.
- access songs from the album the song is on.
- access reviews from the album the review is on.
- interact with input fields for each entity

Next we will create our interactive front-end. It should be an SPA (Single Page Application) that uses JS to build out components that our users can interact with. Use modular JS along with WebPack to create reusable components. This application should allow you to create new artists, albums and songs, edit details about each of the items after they have been created, and delete items.

Entities
- artist
   - id
   - name
   - image
   - albums
   - any other pertinent info. which could include:
      - age
      - record label
      - hometown
- album
   - id
   - title
   - image
   - artist
   - songs (either as a string to be separated, or see below)
   - reviews
   - record label
- song
   - id
   - title
   - album
- review
   - reviewer name
   - content
   - album

## Stretch Tasks
Implement all CRUD operations for songs
- Create endpoint
- Read endpoint
- Update endpoint
- Delete endpoint
Implement all CRUD operations for reviews
- Create endpoint
- Read endpoint
- Update endpoint
- Delete endpoint
