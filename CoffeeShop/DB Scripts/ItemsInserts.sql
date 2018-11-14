use CoffeeShopDB
go

INSERT INTO Items 
([Name], [Description], Quantity, Price)
VALUES 
('PSL', 'A Latte with Pumpkin Spice in it.', 1, 3.00),
('Plain Bagle', 'Carb Goodness.', 1, 1.75),
('Coffee Beans', 'Beans of Coffee.', 200, 15.00),
('Blueberry Muffin', 'A muffin that has blueberries in it.', 1, 1.30),
('Espresso', 'Its an Espresso', 1, 2.50)

select *
from items
