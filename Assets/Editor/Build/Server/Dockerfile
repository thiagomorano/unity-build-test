FROM ubuntu:22.04

WORKDIR /app
COPY . /app

RUN chmod +x unity-test.x86_64

EXPOSE 7777/udp
EXPOSE 7777/tcp

CMD ["./unity-test.x86_64", "-batchmode", "-nographics"]