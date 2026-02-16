SELECT *
FROM products p
RIGHT JOIN orders o 
ON p.product_id = o.product_id
WHERE p.name IS NULL;