CREATE DATABASE IF NOT EXISTS shop_db;
USE shop_db;

-- если таблицы уже есть
DROP TABLE IF EXISTS orders;
DROP TABLE IF EXISTS products;

-- таблица товаров
CREATE TABLE products (
    product_id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    price DECIMAL(10,2) NOT NULL,
    category VARCHAR(50) DEFAULT 'other',
    CONSTRAINT chk_price CHECK (price > 0)
) ENGINE=InnoDB;

-- таблица заказов
CREATE TABLE orders (
    order_id INT AUTO_INCREMENT PRIMARY KEY,
    product_id INT NOT NULL,
    quantity INT NOT NULL,
    order_date DATE NOT NULL DEFAULT CURRENT_DATE,
    CONSTRAINT chk_quantity CHECK (quantity BETWEEN 1 AND 100),
    CONSTRAINT fk_product
        FOREIGN KEY (product_id)
        REFERENCES products(product_id)
) ENGINE=InnoDB;

-- добавление 10 товаров
INSERT INTO products (name, price, category) VALUES
('Laptop', 9500, 'electronics'),
('Smartphone', 8500, 'electronics'),
('Headphones', 3000, 'electronics'),
('T-shirt', 1200, 'clothes'),
('Jeans', 4000, 'clothes'),
('Jacket', 9000, 'clothes'),
('Novel Book', 700, 'books'),
('Cookbook', 1500, 'books'),
('Bread', 150, 'food'),
('Cheese', 800, 'food');