CREATE TABLE order_summary AS
    p.name,
    o.quantity,
    (p.price * o.quantity) AS total_price
FROM orders o
JOIN products p ON o.product_id = p.product_id;