SELECT 
    p.category,
    SUM(p.price * o.quantity) AS total_sum
FROM orders o
JOIN products p ON o.product_id = p.product_id
GROUP BY p.category;