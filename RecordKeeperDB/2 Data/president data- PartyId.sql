
select 2, (select b.bookId from Book b where b.Title = 'Charlie in the Chocolate Factory'), (Select s.shelfId from shelf s where s.Sequence = 1)
union select 5, (select b.bookId from Book b where b.Title = 'The Very Hungry Caterpillar'), (Select s.shelfId from shelf s where s.Sequence = 2)
union select 8, (select b.bookId from Book b where b.Title = 'The Cat In The Hat'), (Select s.shelfId from shelf s where s.Sequence = 3)
union select 4, (select b.bookId from Book b where b.Title = 'The Giving Tree'), (Select s.shelfId from shelf s where s.Sequence = 4)
union select 3, (select b.bookId from Book b where b.Title = 'Little Princess'), (Select s.shelfId from shelf s where s.Sequence = 5)
union select 3, (select b.bookId from Book b where b.Title = 'Alice Adventure in Wonderland'), (Select s.shelfId from shelf s where s.Sequence = 1)
union select 3, (select b.bookId from Book b where b.Title = 'Around the Farm'), (Select s.shelfId from shelf s where s.Sequence = 2)
