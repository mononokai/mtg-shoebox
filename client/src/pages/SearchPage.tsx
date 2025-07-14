import { useEffect, useState } from 'react'
import type { Card } from '../types/Card'
import { fetchCards } from '../services/cardService'

export default function SearchPage() {
  const [cards, setCards] = useState<Card[]>();
  const [input, setInput] = useState<string>('');
  const [isLoading, setIsLoading] = useState<boolean>(false);
  const [errorMessage, setErrorMessage] = useState<string | null>(null);

  // Sends queries to the API
  async function searchCards(query: string) {
    setIsLoading(true);
    setErrorMessage(null);
    
    try {
      const data = await fetchCards(query);
      setCards(data);
    } catch (error) {
      if (error instanceof Error) {
        setErrorMessage(error.message);
        console.error(error.message);
      } else {
        setErrorMessage('Unknown error');
        console.error('An unknown error occurred');
      }
    }

    setIsLoading(false);
  }

  // Press "Enter" to search
  function handleKeyDown(event: React.KeyboardEvent<HTMLInputElement>) {
    if (event.key === 'Enter') {
      searchCards(input || '');
    }
  }

  useEffect(() => {
    searchCards('bolt');
  }, []);

  return (
    <div>
      <div>
        <input
          type="search"
          value={input}
          onChange={(e) => setInput(e.target.value)}
          onKeyDown={handleKeyDown}
        />
        <button
          onClick={() => searchCards(input || '')}
          disabled={input.trim() === ''}
        >
          Search
        </button>
      </div>
      <div>
        {errorMessage && (
          <p style={{ color: 'red '}}>{errorMessage}</p>
        )}

        {isLoading ? (
          <p>Loading...</p>
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
    </div>
  );
}
