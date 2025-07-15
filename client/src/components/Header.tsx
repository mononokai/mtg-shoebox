import styles from './Header.module.css'

export default function Header() {
  return (
    <div className={styles.header}>
      <div className={styles.titleBox}>
        <img src="shoebox.png" alt="MTG Shoebox Logo" className={styles.logo}/>
        <h1 className={styles.title}>MTG Shoebox</h1>
      </div>
      <div></div>
    </div>
  )
}