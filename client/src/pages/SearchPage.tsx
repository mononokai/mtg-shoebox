import { useEffect, useState } from "react"
import type { Card } from "../types/Card"

export default function SearchPage() {
  const [cards, setCards] = useState<Card[]>();
  const [input, setInput] = useState<string>("");

  function searchCards(query: string) {
    fetch(`http://localhost:5276/api/cards?q=${query}`)
      .then(res => res.json())
      .then(data => setCards(data));
  }

  function handleKeyDown(event: React.KeyboardEvent<HTMLInputElement>) {
    if (event.key === "Enter") {
      searchCards(input || "");
    }
  }

  useEffect(() => {
    searchCards("bolt");
  }, []);

  return (
    <div>
      <div>
        <input type="search" value={input} onChange={e => setInput(e.target.value)} onKeyDown={handleKeyDown} />
        <button onClick={() => searchCards(input || "")}>Search</button>
      </div>
      <div>
        {!cards? (
          <p>Loading...</p>
        ) : cards.length === 0 ? (
          <p>No cards found.</p>
        ) : (
          cards.map(card => (
            <p key={card.scryfallId || card.name}>{card.name} {card.manaCost} {card.type} {card.scryfallId ? `(${card.scryfallId})` : ""}</p>
          ))
        )}
      </div>
    </div>
  )
}