use Pokeplace
go

insert into PrivacityLevel (Nome) values ('Privado'), ('Somente para Amigos'), ('Público')

insert into Team (Nome) values ('Instinct'), ('Valor'), ('Mystic')

insert into PokemonType (Nome) values ('Fogo'), ('Água'), ('Planta'), ('Venenoso'), ('Voador'), ('Metal'), ('Fantasma'), ('Sombrio'), ('Pedra'), ('Elétrico'), ('Fada'), ('Dragão')

insert into Pokemon (Nome, Numero, MainTypeId, SecondTypeId) values
('Venussaur', 3, 3, 4),
('Charizard', 6, 2, 5),
('Blastoise', 9, 2, null),
('Heatran', 485, 1, 6)

insert into RaidBoss (PokemonId, Ativo) values (1, 1), (2, 1), (3, 1), (4, 1)