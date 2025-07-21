import type { Card } from '../types/Card'

type SearchResultProps = {
  isLoading: boolean;
  cards?: Card[];
  hasSearched: boolean;
}

export default function SearchResult({ isLoading, cards, hasSearched }: SearchResultProps) {
  return (
    <div>
      {isLoading ? (
          <p>Loading...</p>
        ) : !hasSearched ? (
          <p>Search for a card to get started!</p>
        ) : !cards ? (
          <p>Something went wrong.</p>
        ) : cards.length === 0 ? (
          <p>No cards found.</p>
        ) : (
          cards.map((card) => (
            <p key={card.scryfallId || card.name}>
              {card.name} {card.manaCost} {card.type}{' '}
              {card.scryfallId ? `(${card.scryfallId})` : ''}
            </p>
          ))
        )}
    </div>
  );
}