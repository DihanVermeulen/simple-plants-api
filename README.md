# Simple Plants API

A very simple, non entertaining plants api as part of my code portfolio to showcase my basic understanding of programming principles and the .Net platform.

## Dependencies

- .Net 7.0
- Docker (optional)

## Installation

Clone this repository from https://github.com/DihanVermeulen/simple-plants-api.

```bash
git clone https://github.com/DihanVermeulen/simple-plants-api
```

Restore the project repositories

```bash
dotnet restore
```

## Run locally

Run the project

```bash
dotnet run
```

OR

Build docker image

```bash
 docker build *image name* .
```

Run docker image in container

```bash
docker run -d -p 5000:80 *image name*
```
