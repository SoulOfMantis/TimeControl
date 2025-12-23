FROM rust:1.92 AS builder
WORKDIR /work
COPY . .
RUN cargo build --release

FROM debian:bullseye-slim
WORKDIR /work
RUN apt-get update && apt-get install -y libssl-dev && rm -rf /var/lib/apt/lists/*
COPY --from=builder /work/target/release/rust_tripples .
CMD ["./rust_tripples"]