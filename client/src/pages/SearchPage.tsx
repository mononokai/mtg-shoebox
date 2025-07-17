import { useEffect, useState } from 'react';
import type { Card } from '../types/Card';
import { fetchCards } from '../services/cardService';
import SearchResult from '../components/SearchResult';
import { useSearchParams } from 'react-router-dom';

export default function SearchPage() {
  const [cards, setCards] = useState<Card[]>();
  const [input, setInput] = useState<string>('');
  const [isLoading, setIsLoading] = useState<boolean>(false);
  const [errorMessage, setErrorMessage] = useState<string | null>(null);
  const [hasSearched, setHasSearched] = useState<boolean>(false);
  const [searchParams] = useSearchParams();

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
    setHasSearched(true);
  }

  // Press "Enter" to search
  function handleKeyDown(event: React.KeyboardEvent<HTMLInputElement>) {
    if (event.key === 'Enter') {
      searchCards(input || '');
    }
  }

  // Submit search on page load if there is a "q" value in URL
  useEffect(() => {
    const q = searchParams.get('q');

    if (q !== null && q.trim() !== '') {
      searchCards(q);
    }
  }, [searchParams]);

  // On page load, set input value to match "q" value in URL
  useEffect(() => {
    const q = searchParams.get('q');

    if (q !== null && q !== input) {
      setInput(q);
    }
    // Suppress ESLint warning - only using input for comparison
    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, [searchParams]);

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
        {errorMessage && <p style={{ color: 'red ' }}>{errorMessage}</p>}
        <SearchResult
          isLoading={isLoading}
          cards={cards}
          // Check if there's a "q" value in URL
          hasSearched={hasSearched && !!searchParams.get('q')}
        />
      </div>
    </div>
  );
}
